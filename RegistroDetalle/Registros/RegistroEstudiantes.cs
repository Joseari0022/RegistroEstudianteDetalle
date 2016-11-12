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
using EjemploDetalle;

namespace RegistroDetalle
{
    public partial class RegistroEstudiantes : Form
    {
        public RegistroEstudiantes()
        {
            InitializeComponent();
        }

        Utilidades u = new Utilidades();
        Estudiantes estud = new Estudiantes();
        private void Idbutton_Click(object sender, EventArgs e)
        {
            if (ValidId() && ValidBus())
                Pasar(EstudianteBll.Buscar(u.StringToInt(IdtextBox.Text)));
        }

        private void Pasar(Estudiantes est)
        {
            var es = EstudianteBll.Buscar(u.StringToInt(IdtextBox.Text));
            IdtextBox.Text = est.EstudianteId.ToString();
            NombretextBox.Text = est.Nombres;
            GrupodataGridView.DataSource = null;
            GrupodataGridView.DataSource = est.Grupos;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            LlenarClase(estud);
            if (ValidTextB() && ValidExi(NombretextBox.Text))
            {
                EstudianteBll.Guardar(estud);
                MessageBox.Show("Guardado con exito!!!");
            }
                
        }

        private void LlenarClase(Estudiantes estudiantes)
        {
            estudiantes.Nombres = NombretextBox.Text;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (ValidId() && ValidBus())
            {
                EstudianteBll.Eliminar(u.StringToInt(IdtextBox.Text));
                MessageBox.Show("Eliminado con exito!!!");
            }
        }

        private bool ValidId()
        {
            if (string.IsNullOrEmpty(IdtextBox.Text))
            {
                MessageBox.Show("Por Favor Ingrese El Id");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidBus()
        {
            if (GrupoBll.Buscar(u.StringToInt(IdtextBox.Text)) == null)
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
            GrupodataGridView.DataSource = null;
        }

        private bool ValidTextB()
        {
            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                NombreerrorProvider.SetError(NombretextBox, "Ingrese Nombre");
                MessageBox.Show("Llenar todo los campos");
            }
            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                NombreerrorProvider.Clear();
                NombreerrorProvider.SetError(NombretextBox, "Ingrese Nombre");
                return false;
            }
            return true;
        }

        private bool ValidExi(string au)
        {
            if (EstudianteBll.GetListaNombre(au).Count() > 0)
            {
                MessageBox.Show("Este nombre existe");
                return false;
            }
            return true;
        }

        
    }
}
