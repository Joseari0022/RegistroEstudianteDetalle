﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDetalle
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEstudiantes re = new RegistroEstudiantes();
            re.MdiParent = this.MdiParent;
            re.Show();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistroGrupos rg = new Registros.RegistroGrupos();
            rg.MdiParent = this.MdiParent;
            rg.Show();
        }

        private void estudiantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaEstudiantes ce = new Consultas.ConsultaEstudiantes();
            ce.MdiParent = this.MdiParent;
            ce.Show();
        }

        private void gruposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaGrupos cg = new Consultas.ConsultaGrupos();
            cg.MdiParent = this.MdiParent;
            cg.Show();
        }
    }
}
