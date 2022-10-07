using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mime;

namespace Afy
{
    public partial class afyregistro : Form
    {
        public afyregistro()
        {
            InitializeComponent();
            int idioma = Idioma.Tipoidioma;
            if(idioma == 1)
            {
                idiomaEspañol();
            } else
            {
                idiomaIngles();
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            AfyUsuario usuario = new AfyUsuario();
            usuario.Email = txtEmail.Text;
            usuario.Usuario = txtUser.Text;
            usuario.Contrasenia = txtContrasenia.Text;
            usuario.ConfirmarContrasenia = txtConfirmar.Text;
  
            try
            {
                AfyConsultaSQL afyc = new AfyConsultaSQL();
                string resultado = afyc.Registro(usuario);
                if(resultado == "ok")
                {
                    MessageBox.Show("Usuario registrado correctamente.");
                    borrar();                
                } else
                {
                    MessageBox.Show(resultado);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }                             
        }
        
        public void borrar()
        {
            txtEmail.Text = "";
            txtUser.Text = "";
            txtContrasenia.Text = "";
            txtConfirmar.Text = "";

        }
        private void chbOcultar_CheckedChanged(object sender, EventArgs e)
        {
            if(chbOcultar.Checked == true)
            {
                pbMostrar.BringToFront();
                txtContrasenia.PasswordChar = '\0';
                txtConfirmar.PasswordChar = '\0';
            } else
            {
                pbOcultar.BringToFront();
                txtContrasenia.PasswordChar = '*';
                txtConfirmar.PasswordChar = '*';
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            afyInicio afyi = new afyInicio();
            this.Hide();
            afyi.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            afylogin afyl = new afylogin();
            this.Hide();
            afyl.Show();
        }

        private void afyregistro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void idiomaEspañol()
        {
            btnLogin.Text = "Login";
            btnVolver.Text = "Volver";
            idiomaToolStripMenuItem.Text = "Idioma";
            españolToolStripMenuItem.Text = "Español";
            inglésToolStripMenuItem.Text = "Inglés";
            btnRegistro.Text = "Registrarme";
            label1.Text = "Mail: ";
            label2.Text = "Usuario: ";
            label3.Text = "Contraseña: ";
            label4.Text = "¿Tienes una cuenta?";
            label5.Text = "Confirmar contraseña: ";
            Idioma.tipoidioma = 1;
        }

        private void idiomaIngles()
        {
            btnLogin.Text = "Sign in";
            btnVolver.Text = "Back";
            idiomaToolStripMenuItem.Text = "Language";
            españolToolStripMenuItem.Text = "Spanish";
            inglésToolStripMenuItem.Text = "English";
            label1.Text = "Address: ";
            label2.Text = "Username: ";
            label3.Text = "Password: ";
            label4.Text = "You already have an account?";
            label5.Text = "Confirm Password: ";
            btnRegistro.Text = "Sign up";
            Idioma.tipoidioma = 2;
        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {

        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Idioma.Tipoidioma == 2)
            {
                idiomaEspañol();
                MessageBox.Show("Idioma cambiado correctamente.");
            }
            else
            {
                MessageBox.Show("Su idioma ya es el español.");
            }
        }

        private void inglésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Idioma.Tipoidioma == 1)
            {
                idiomaIngles();
                MessageBox.Show("Language changed successfully.");
            }
            else
            {
                MessageBox.Show("Your language is already English.");
            }
        }

        private void afyregistro_Load(object sender, EventArgs e)
        {

        }
    }
}
