using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Afy
{
    public partial class AfyAdmin : Form
    {
        public AfyAdmin()
        {
            InitializeComponent();
        }

        private void eliminarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afyAdminConsulta afya = new afyAdminConsulta();
            this.Hide();
            afya.Show();
        }

        private void gestorDePublicidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfyPublicidad afyp = new AfyPublicidad();
            this.Hide();
            afyp.Show();
        }

        private void AfyAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
