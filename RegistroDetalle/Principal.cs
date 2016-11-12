using System;
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
    }
}
