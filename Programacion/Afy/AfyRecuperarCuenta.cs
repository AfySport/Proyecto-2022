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
    public partial class AfyRecuperarCuenta : Form
    {
        public AfyRecuperarCuenta()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AfyConsultaSQL afy = new AfyConsultaSQL();
            string email = txtMail.Text;
            string respuesta = afy.recuperarUsuario(email);
            if(respuesta == "ok")
            {
                MessageBox.Show("Correo de recuperación enviado correctamente al mail " + email);
            } else
            {
                MessageBox.Show(respuesta);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            afylogin afy = new afylogin();
            afy.Show();
            this.Hide();
        }
    }
}
