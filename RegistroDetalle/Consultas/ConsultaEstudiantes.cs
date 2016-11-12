using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BLL;
using Detalle;

namespace RegistroDetalle.Consultas
{
    public partial class ConsultaEstudiantes : Form
    {
        public ConsultaEstudiantes()
        {
            InitializeComponent();
        }

        Utilidades u = new Utilidades();
        Estudiantes estud = new Estudiantes();
        private void Idbutton_Click(object sender, EventArgs e)
        {
            if (ValidarConsul() == true)
                BuscarId(EstudianteBll.Buscar(u.StringToInt(FiltrotextBox.Text)));
        }

        private void BuscarId(Estudiantes est)
        {
            var estu = EstudianteBll.Buscar(u.StringToInt(FiltrotextBox.Text));
            FiltrotextBox.Text = est.EstudianteId.ToString();
            NombretextBox.Text = est.Nombres;
            ConsultaEstudiantedataGridView.DataSource = null;
            ConsultaEstudiantedataGridView.DataSource = est.Grupos;
        }

        private void Llenar(string aux)
        {
            var est = EstudianteBll.GetListaNombre((FiltrotextBox.Text));
            FiltrotextBox.Text = estud.Nombres;
            ConsultaEstudiantedataGridView.DataSource = null;
            ConsultaEstudiantedataGridView.DataSource = estud.Grupos;
        }

        private void ConsultaEstudiantes_Load(object sender, EventArgs e)
        {
            LlenarFiltro();
        }

        private void LlenarFiltro()
        {
            FiltrarcomboBox.Items.Insert(0, "EstudianteId");
            FiltrarcomboBox.Items.Insert(1, "Nombres");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = " Id";
        }

        private bool ValidarConsul()
        {
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                if (string.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    IderrorProvider.SetError(FiltrotextBox, "Ingrese el campo....");

                    return false;
                }
                if (FiltrarcomboBox.SelectedIndex == 1 && GrupoBll.GetListaNombre(FiltrotextBox.Text).Count == 0)
                {
                    MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                    return false;
                }
            }
            IderrorProvider.Clear();
            return true;
        }
    }
}
