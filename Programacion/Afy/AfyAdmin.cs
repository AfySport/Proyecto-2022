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

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afyInicio afyi = new afyInicio();
            switch (Idioma.Tipoidioma)
            {
                case 1:
                    MessageBox.Show("Esperemos que vuelva pronto, admin");
                    break;
                case 2:
                    MessageBox.Show("We hope to see you again soon, admin!");
                    break;
            }
            this.Hide();
            afyi.Show();
            AfySesion reinicio = new AfySesion(); //Reiniciar credenciales.
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfyAjustesCuenta afy = new AfyAjustesCuenta();
            this.Hide();
            afy.Show();
        }

        private void panelDeEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfyPanelEventos afy = new AfyPanelEventos();
            afy.Show();
            this.Hide();
        }
    }
}
