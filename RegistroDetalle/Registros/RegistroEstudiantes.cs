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

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            LlenarClase(estud);
            EstudianteBll.Guardar(estud);
            MessageBox.Show("Guardado con exito!!!");
        }

        private void LlenarClase(Estudiantes estudiantes)
        {
            estudiantes.Nombres = NombretextBox.Text;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            EstudianteBll.Eliminar(u.StringToInt(IdtextBox.Text));
            MessageBox.Show("Eliminado con exito!!!");
        }
    }
}
