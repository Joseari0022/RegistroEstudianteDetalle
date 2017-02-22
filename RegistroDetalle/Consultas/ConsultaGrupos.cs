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
    public partial class ConsultaGrupos : Form
    {
        public ConsultaGrupos()
        {
            InitializeComponent();
        }
        Utilidades u = new Utilidades();
        Grupos gru = new Grupos();
        private void Idbutton_Click(object sender, EventArgs e)
        {
            if (ValidarConsul() == true)
                BuscaId(GrupoBll.Buscar(u.StringToInt(FiltrotextBox.Text)));
        }

        private void BuscaId(Grupos gru)
        {
            var estd = GrupoBll.Buscar(u.StringToInt(FiltrotextBox.Text));
            FiltrotextBox.Text = gru.GrupoId.ToString();
            NombretextBox.Text = gru.Nombres;
            ConsultaGrupodataGridView.DataSource = null;
            ConsultaGrupodataGridView.DataSource = gru.Estudiantes;
        }

       //// private void Llenar(string aux)
       // {
       //     var grup = GrupoBll.GetListaNombre((FiltrotextBox.Text));
       //     FiltrotextBox.Text = gru.Nombres;
       //     ConsultaGrupodataGridView.DataSource = null;
       //     ConsultaGrupodataGridView.DataSource = gru.Estudiantes;
       // }

        private void ConsultaGrupos_Load(object sender, EventArgs e)
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
            if(FiltrarcomboBox.SelectedIndex == 0)
            {
                if (string.IsNullOrEmpty(FiltrotextBox.Text))
                {
                    IderrorProvider.SetError(FiltrotextBox, "Ingrese el campo....");

                    return false;
                }
                if(FiltrarcomboBox.SelectedIndex == 1 && GrupoBll.GetListaNombre(FiltrotextBox.Text).Count == 0)
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
