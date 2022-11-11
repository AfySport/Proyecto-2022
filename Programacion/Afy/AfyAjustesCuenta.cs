using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                if(AfySesion.tipo == "U-NoSuscrito")
                {
                    lblNoSuscrito.Visible = true;
                } else
                {
                    if (AfySesion.tipo == "Admin")
                    {
                        lblAdmin.Visible = true;
                    }
                }
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
            label5.Text = "Status:";
            lblNoSuscrito.Text = "Non-suscriber";
            lblSuscrito.Text = "ACTIVE";
            btnVolver.Text = "Back";
            lblAdmin.Text = "Admin";
            Idioma.tipoidioma = 2;
        }

        private void idiomaEspaniol()
        {
            label1.Text = "Email:";
            label2.Text = "Usuario:";
            label3.Text = "Contraseña:";
            label4.Text = "Datos de cuenta";
            label5.Text = "Estado:";
            lblNoSuscrito.Text = "No suscrito";
            lblSuscrito.Text = "ACTIVO";
            btnVolver.Text = "Volver";
            Idioma.tipoidioma = 1;
        }

        //int azar1;
        //int azar2;
        //private void temporizador_Tick(object sender, EventArgs e)
        //{
        //    AfyConsultaSQL afy = new AfyConsultaSQL();
        //    AfyPublicidad afyp = new AfyPublicidad();
        //    tiempo++;
        //    lblContador.Text = tiempo.ToString();
        //    int maximo = afy.cantidadImagenes();
        //    if (lblContador.Text == "2")
        //    {
        //        Random r = new Random();
        //        azar1 = r.Next(1, maximo);
        //        azar2 = r.Next(1, maximo);
        //        MemoryStream imagenAzar1 = afy.mostrarImagen(azar1);
        //        Bitmap bitmap = new Bitmap(imagenAzar1);
        //        MemoryStream imagenAzar2 = afy.mostrarImagen(azar2);
        //        Bitmap bitmap2 = new Bitmap(imagenAzar2);
        //        pb1.Image = bitmap;
        //        pb2.Image = bitmap2;
        //        temporizador.Enabled = false;
        //        tiempo = 0;
        //        lblContador.Text = "0";
        //        temporizador.Start();
        //    }
        //}

        private void AfyAjustesCuenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if(AfySesion.tipo == "Admin")
            {
                AfyAdmin a = new AfyAdmin();
                this.Hide();
                a.Show();
            } else
            {
                AfySport afy = new AfySport();
                this.Hide();
                afy.Show();
            }
        }
    }
}
