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

namespace RegistroDetalle.Registros
{
    public partial class RegistroGrupos : Form
    {
        public RegistroGrupos()
        {
            InitializeComponent();
        }
        Utilidades u = new Utilidades();
        Grupos gruo = new Grupos(); 
        private void Idbutton_Click(object sender, EventArgs e)
        {
            if(ValidId() && ValidBus())
            Pasar(GrupoBll.Buscar(u.StringToInt(IdtextBox.Text)));
        }

        private void Pasar(Grupos gr)
        {
            var g = GrupoBll.Buscar(u.StringToInt(IdtextBox.Text));
            IdtextBox.Text = gr.GrupoId.ToString();
            NombretextBox.Text = gr.Nombres;
            EstudiantedataGridView.DataSource = null;
            EstudiantedataGridView.DataSource = gr.Estudiantes;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            LlenarClase(gruo);
            if (ValidTextB() && ValidExi(NombretextBox.Text))
            {
                GrupoBll.Guardar(gruo);
                MessageBox.Show("Guardado con exito!!!");
            }
        }

        private void LlenarClase(Grupos grup)
        {
            grup.Nombres = NombretextBox.Text;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (ValidId() && ValidBus())
            {
                GrupoBll.Eliminar(u.StringToInt(IdtextBox.Text));
                MessageBox.Show("Eliminado con exito!!!");
            }
        }

        private void LlenarCombo()
        {
            EstudiantescomboBox.DataSource = EstudianteBll.GetLista();
            EstudiantescomboBox.ValueMember = "EstudianteId";
            EstudiantescomboBox.DisplayMember = "Nombres";
        }

        private void RegistroGrupos_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            gruo.Estudiantes.Add(new Estudiantes((int)EstudiantescomboBox.SelectedValue, EstudiantescomboBox.Text));
            EstudiantedataGridView.DataSource = null;
            EstudiantedataGridView.DataSource = gruo.Estudiantes;
        }

        private bool ValidId()
        {
            if(string.IsNullOrEmpty(IdtextBox.Text))
            {
                MessageBox.Show("Por Favor Ingrese El Id");
                return false;
            }else
            {
                return true;
            }
        }

        private bool ValidBus()
        {
            if(GrupoBll.Buscar(u.StringToInt(IdtextBox.Text)) == null)
            {
                MessageBox.Show("Este Grupo no existe");
                return false;
            }
            return true;
        }

        private void Clear()
        {
            IdtextBox.Clear();
            NombretextBox.Clear();
            NombreerrorProvider.Clear();
            EstudiantedataGridView.DataSource = null;
        }
        
        private bool ValidTextB()
        {
            if(string.IsNullOrEmpty(NombretextBox.Text))
            {
                NombreerrorProvider.SetError(NombretextBox, "Ingrese Nombre");
                MessageBox.Show("Llenar todo los campos");
            }
            if(string.IsNullOrEmpty(NombretextBox.Text))
            {
                NombreerrorProvider.Clear();
                NombreerrorProvider.SetError(NombretextBox, "Ingrese Nombre");
                return false;
            }
            return true;
        }

        private bool ValidExi(string au)
        {
            if(GrupoBll.GetListaNombre(au).Count() > 0)
            {
                MessageBox.Show("Este nombre existe");
                return false;
            }
            return true;
        }
    }
 }

