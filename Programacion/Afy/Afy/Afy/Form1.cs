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
    public partial class afyInicio : Form
    {
        public afyInicio()
        {
            InitializeComponent();
        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            afyregistro afyr = new afyregistro();
            this.Hide();
            afyr.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            afylogin afyl = new afylogin();
            this.Hide();
            afyl.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void afyInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
