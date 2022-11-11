using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Afy
{
    public partial class afylogin : Form
    {
        public afylogin()
        {
            InitializeComponent();
            int idioma = Idioma.Tipoidioma;
            if(idioma == 1)
            {
                idiomaEspaniol();
            }
            else
            {
                idiomaIngles();
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            afyregistro a = new afyregistro();
            this.Hide();
            a.Show();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            afyInicio afyi = new afyInicio();
            this.Hide();
            afyi.Show();
        }
        private void txtUserOrMail_Click(object sender, EventArgs e)
        {                    
        }
        private void txtUserOrMail_Leave(object sender, EventArgs e)
        {                    
        }
        private void idiomaIngles()
        {            
            label1.Text = "Username:";
            label2.Text = "Password:";
            label3.Text = "Dont have an account?:";
            btnLogin.Text = "Sign In";
            btnRegistrar.Text = "Sign Up";
            btnVolver.Text = "Back";
            idiomaToolStripMenuItem.Text = "Language";
            españolToolStripMenuItem.Text = "Spanish";
            inglésToolStripMenuItem.Text = "English";
            Idioma.tipoidioma = 2;
        }
        private void idiomaEspaniol()
        {           
            label1.Text = "Usuario:";
            label2.Text = "Contraseña:";
            label3.Text = "¿No tienes una cuenta?:";
            btnLogin.Text = "Login";
            btnRegistrar.Text = "Registrarme";
            btnVolver.Text = "Volver";
            idiomaToolStripMenuItem.Text = "Idioma";
            españolToolStripMenuItem.Text = "Español";
            inglésToolStripMenuItem.Text = "Inglés";
            Idioma.tipoidioma = 1;
        }

        public bool comprobarNumeros(string cadena)
        {
            int aux;
            if(Int32.TryParse(cadena, out aux) == true)
            {
                return true;
            } else
            {
                return false;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string usuarioOMail = txtUserOrMail.Text;
            string contrasenia = txtContrasenia.Text;
            try
            {
                AfyConsultaSQL afylogin = new AfyConsultaSQL();
                string respuesta = afylogin.Login(usuarioOMail, contrasenia);

                bool encontro = false;
                if (respuesta == "Coincide")
                    encontro = true;

                if (encontro == true) //Ingresa a la aplicación.
                {
                    if (AfySesion.tipo == "U-NoSuscrito" || AfySesion.tipo.Equals("U-Suscrito"))
                    {
                        AfySport afys = new AfySport();
                        MessageBox.Show(usuarioOMail + " ingreso correctamente a AfySports!");
                        this.Hide();
                        afys.Show();
                    }
                    else if (AfySesion.tipo == "Admin")
                    {
                        {
                            AfyAdmin afya = new AfyAdmin();
                            MessageBox.Show(usuarioOMail + " ingreso correctamente como ADMINISTRADOR");
                            this.Hide();
                            afya.Show();
                        }
                    }
                }
                else //Algun error.
                {
                    MessageBox.Show(respuesta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtContrasenia_Click(object sender, EventArgs e)
        {
            
        }
        private void txtContrasenia_Leave(object sender, EventArgs e)
        {
            
        }
        private void afylogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Idioma.Tipoidioma == 2)
            {
                idiomaEspaniol();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            AfyRecuperarCuenta a = new AfyRecuperarCuenta();
            a.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
