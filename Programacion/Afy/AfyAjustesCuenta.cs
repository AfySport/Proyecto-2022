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
    public partial class AfyAjustesCuenta : Form
    {
        public AfyAjustesCuenta()
        {
            InitializeComponent();
            txtEmail.Text = AfySesion.Email;
            txtUsuario.Text = AfySesion.usuario;
            txtContrasenia.Text = AfySesion.contrasenia;
            if(AfySesion.tipo == "U-Suscrito")
            {
                lblSuscrito.Visible = true;
            } else
            {
                lblNoSuscrito.Visible = true;
            }
            if(Idioma.tipoidioma == 1)
            {
                idiomaEspaniol();
            } else
            {
                idiomaIngles();
            }
        }

        private void idiomaIngles()
        {
            label1.Text = "Mail:";
            label2.Text = "User:";
            label3.Text = "Password:";
            label4.Text = "Account settings";
            label5.Text = "Suscription status:";
            lblNoSuscrito.Text = "Non-suscriber";
            lblSuscrito.Text = "ACTIVE";
            btnVolver.Text = "Back";
            Idioma.tipoidioma = 2;
        }

        private void idiomaEspaniol()
        {
            label1.Text = "Email:";
            label2.Text = "Usuario:";
            label3.Text = "Contraseña:";
            label4.Text = "Datos de cuenta";
            label5.Text = "Estado de suscripción:";
            lblNoSuscrito.Text = "No suscrito";
            lblSuscrito.Text = "ACTIVO";
            btnVolver.Text = "Volver";
            Idioma.tipoidioma = 1;
        }

        private void AfyAjustesCuenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            AfySport afy = new AfySport();
            this.Hide();
            afy.Show();
        }
    }
}
