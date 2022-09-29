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
                if(resultado.Length > 0)
                {
                    MessageBox.Show(resultado);                                       
                } else
                {
                    MessageBox.Show("Usuario registrado correctamente.");                   
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
    }
}
