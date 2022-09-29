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
                else
                    encontro = false;

                if(encontro == true) //Ingresa a la aplicación.
                {
                    if (AfySesion.tipo == "U-NoSuscrito" || AfySesion.tipo.Equals("U-Suscrito"))
                    {
                        AfySport afys = new AfySport();
                        MessageBox.Show(usuarioOMail + " ingreso correctamente a AfySports!");
                        this.Hide();
                        afys.Show();
                    } else if(AfySesion.tipo == "Admin")
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
            }catch(Exception ex)
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
    }
}
