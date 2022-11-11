using MySql.Data.MySqlClient;
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
    public partial class AfySport : Form
    {
        private int tiempo = 0;

        public AfySport()
        {           
            InitializeComponent();
            string tipoUsuario = AfySesion.tipo;
            lblNombre.Text = AfySesion.usuario;
            if (tipoUsuario.Equals("U-NoSuscrito"))
            {
                pb2.Visible = true;
                pictureBox1.Visible = true;
                temporizador.Start();
                hacermeSuscriptorToolStripMenuItem.Visible = true;
            } else
            {
                if(tipoUsuario.Equals("SinRegistro"))
                {
                    pb2.Visible = true;
                    temporizador.Start();
                    menuStrip1.Visible = true;
                    ingresarToolStripMenuItem.Visible = true;
                    registrarmeToolStripMenuItem.Visible = true;
                    loguearmeToolStripMenuItem.Visible = true;
                    cuentaToolStripMenuItem.Visible = false;
                    cambiarDeIdiomaToolStripMenuItem.Visible = false;
                    pictureBox1.Visible = true;
                } 
            }
            if (Idioma.Tipoidioma == 1)
            {
                idiomaEspaniol();
            }
            else if (Idioma.tipoidioma == 2)
            {
                idiomaIngles();
            }
        }

        private void AfySport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        int azar1;
        int azar2;
        private void temporizador_Tick(object sender, EventArgs e)
        {
            AfyConsultaSQL afy = new AfyConsultaSQL();
            AfyPublicidad afyp = new AfyPublicidad();            
            tiempo++;
            lblContador.Text = tiempo.ToString();
            int maximo = afy.cantidadImagenes();
            if (lblContador.Text == "18")
            {                
                Random r = new Random();
                azar1 = r.Next(1, maximo);
                azar2 = r.Next(1, maximo);
                MemoryStream imagenAzar1 = afy.mostrarImagen(azar1);
                Bitmap bitmap = new Bitmap(imagenAzar1);
                MemoryStream imagenAzar2 = afy.mostrarImagen(azar2);
                Bitmap bitmap2 = new Bitmap(imagenAzar2);
                pb2.Image = bitmap2;
                temporizador.Enabled = false;
                tiempo = 0;
                lblContador.Text = "0";
                temporizador.Start();
            }
        }

        private void cambiarDeIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afyInicio afyi = new afyInicio();
            switch (Idioma.Tipoidioma)
            {
                case 1:
                    MessageBox.Show("¡Esperemos que vuelva pronto!");
                    break;
                case 2:
                    MessageBox.Show("We hope to see you again soon!");
                    break;
            }           
            this.Hide();
            afyi.Show();
            AfySesion reinicio = new AfySesion(); //Reiniciar credenciales.
        }

        private void cuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hacermeSuscriptorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void idiomaEspaniol()
        {
            Idioma.Tipoidioma = 1;
            configuraciónToolStripMenuItem.Text = "Configuracion";
            cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            cambiarDeIdiomaToolStripMenuItem.Text = "Idioma";
            cuentaToolStripMenuItem.Text = "Mi cuenta";
            hacermeSuscriptorToolStripMenuItem.Text = "Hacerme suscriptor";
            españolToolStripMenuItem.Text = "Español";
            inglésToolStripMenuItem.Text = "Inglés";
            toolStripMenuItem1.Text = "Ajustes";
            label1.Text = "Bienvenido,";
        }

        private void idiomaIngles()
        {
            Idioma.tipoidioma = 2;
            configuraciónToolStripMenuItem.Text = "Settings";
            hacermeSuscriptorToolStripMenuItem.Text = "Suscribe";
            cambiarDeIdiomaToolStripMenuItem.Text = "Language";
            cerrarSesiónToolStripMenuItem.Text = "Log Out";
            españolToolStripMenuItem.Text = "Spanish";
            cuentaToolStripMenuItem.Text = "My account";
            inglésToolStripMenuItem.Text = "English";
            toolStripMenuItem1.Text = "Settings";
            label1.Text = "Welcome,";
        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Idioma.Tipoidioma == 1)
            {
                MessageBox.Show("Su idioma ya está en español.");
            }
            else
            {
                idiomaEspaniol();
                MessageBox.Show("Idioma cambiado correctamente");
            }
        }

        private void inglésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Idioma.Tipoidioma == 2)
            {
                MessageBox.Show("Your language is already English.");
            }
            else
            {
                idiomaIngles();
                MessageBox.Show("Language changed successfully.");
            }
        }

        private void hacermeSuscriptorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AfyNuevoSuscriptor afyn = new AfyNuevoSuscriptor();
            afyn.Show();
            this.Hide();
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfyAjustesCuenta afyc = new AfyAjustesCuenta();
            afyc.Show();
            this.Hide();
        }

        private void registrarmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afyregistro a = new afyregistro();
            MessageBox.Show("Cambiando a registro..");
            this.Hide();
            a.Show();
            AfySesion reinicio = new AfySesion(); //Reinicio credenciales.
        }

        private void loguearmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afylogin a = new afylogin();
            MessageBox.Show("Cambiando a login..");
            this.Hide();
            a.Show();
            AfySesion reinicio = new AfySesion(); //Reinicio credenciales.
        }

        private void AfySport_Load(object sender, EventArgs e)
        {
            AfyConsultaSQL a = new AfyConsultaSQL();            
            MySqlDataReader readerEv1 = a.devolverDatosEventos(1);
            if (readerEv1.HasRows)
            {
            while (readerEv1.Read())
            {
                    string numLocal = readerEv1[0].ToString();
                    string numVis = readerEv1[2].ToString();
                    string nomVis = a.obtenerNombreDeJugador(int.Parse(numVis));
                    string nomLocal = a.obtenerNombreDeJugador(int.Parse(numLocal));
                    lblLocalEv1.Text = nomLocal;
                    lblVisitanteEv1.Text = nomVis;
                    lblFechaEv1.Text = readerEv1[4].ToString();
                    lblResultadoLocalEv1.Text = "["+readerEv1[1].ToString()+"]";
                    lblResultadoEv1Vis.Text = "["+readerEv1[3].ToString()+"]";
                    lblDeporteEv1.Text = readerEv1[5].ToString();
                    string fechaAux = readerEv1[4].ToString();
                    string fechaHoy = DateTime.Today.ToShortDateString();
                    if (fechaAux == fechaHoy)
                    {
                        lblEv1.ForeColor = Color.Lime;
                        lblEv1.Text = "En juego...";
                    } else
                    {
                        lblEv1.ForeColor = Color.Lime;
                        lblEv1.Text = "Proximo evento...";
                    }
            }
            } else
            {
                lblEv1.ForeColor = Color.Red;
                lblEv1.Text = "Sin evento...";
            }
            AfySQL aa = new AfySQL();
            MySqlDataReader readerEv2 = a.devolverDatosEventosEquipos(2);
            if (readerEv2.HasRows)
            {
                while (readerEv2.Read())
                {
                    string numLocal = readerEv2[1].ToString();
                    string numVis = readerEv2[3].ToString();
                    string nomSelVis = aa.obtenerNombreDeSeleccion(int.Parse(numVis));
                    string nomSelLocal = aa.obtenerNombreDeSeleccion(int.Parse(numLocal));
                    lblLocalEv2.Text = nomSelLocal;
                    lblVisitanteEv2.Text = nomSelVis;
                    lblFechaEv2.Text = readerEv2[0].ToString();
                    lblResultadoEv2Local.Text = "[" + readerEv2[2].ToString() + "]";
                    lblResultadoEv2Vis.Text = "[" + readerEv2[4].ToString() + "]";
                    lblDeporteEv2.Text = readerEv2[5].ToString();
                    string fechaAux = readerEv2[0].ToString();
                    string fechaHoy = DateTime.Today.ToShortDateString();
                    if (fechaAux == fechaHoy)
                    {
                        lblEv2.ForeColor = Color.Lime;
                        lblEv2.Text = "En juego...";
                    }
                    else
                    {
                        lblEv2.ForeColor = Color.Lime;
                        lblEv2.Text = "Proximo evento...";
                    }
                }
            }
            else
            {
                lblEv2.ForeColor = Color.Red;
                lblEv2.Text = "Sin evento...";
            }

            MySqlDataReader readerEv3 = a.devolverDatosEventosEquipos(3);
            if (readerEv3.HasRows)
            {
                while (readerEv3.Read())
                {
                    string numLocal = readerEv3[1].ToString();
                    string numVis = readerEv3[3].ToString();
                    string nomSelVis = aa.obtenerNombreDeSeleccion(int.Parse(numVis));
                    string nomSelLocal = aa.obtenerNombreDeSeleccion(int.Parse(numLocal));
                    lblLocalEv3.Text = nomSelLocal;
                    lblVisitanteEv3.Text = nomSelVis;
                    lblFechaEv3.Text = readerEv3[0].ToString();
                    lblResultadoEv3Local.Text = "[" + readerEv3[2].ToString() + "]";
                    lblResultadoEv3Vis.Text = "[" + readerEv3[4].ToString() + "]";
                    lblDeporteEv3.Text = readerEv3[5].ToString();
                    string fechaAux = readerEv3[0].ToString();
                    string fechaHoy = DateTime.Today.ToShortDateString();
                    if (fechaAux == fechaHoy)
                    {
                        lblEv3.ForeColor = Color.Lime;
                        lblEv3.Text = "En juego...";
                    }
                    else
                    {
                        lblEv3.ForeColor = Color.Lime;
                        lblEv3.Text = "Proximo evento...";
                    }
                }
            }
            else
            {
                lblEv3.ForeColor = Color.Red;
                lblEv3.Text = "Sin evento...";
            }

            MySqlDataReader readerEv4 = a.devolverDatosEventos(4);
            if (readerEv4.HasRows)
            {
                while (readerEv4.Read())
                {
                    string numLocal = readerEv4[0].ToString();
                    string numVis = readerEv4[2].ToString();
                    string nomVis = a.obtenerNombreDeJugador(int.Parse(numVis));
                    string nomLocal = a.obtenerNombreDeJugador(int.Parse(numLocal));
                    lblLocalEv4.Text = nomLocal;
                    lblVisitanteEv4.Text = nomVis;
                    lblFechaEv4.Text = readerEv4[4].ToString();
                    lblResultadoEv4Local.Text = "[" + readerEv4[1].ToString() + "]";
                    lblResultadoEv4Vis.Text = "[" + readerEv4[3].ToString() + "]";
                    lblDeporteEv4.Text = readerEv4[5].ToString();
                    string fechaAux = readerEv4[4].ToString();
                    string fechaHoy = DateTime.Today.ToShortDateString();
                    if (fechaAux == fechaHoy)
                    {
                        lblEv4.ForeColor = Color.Lime;
                        lblEv4.Text = "En juego...";
                    }
                    else
                    {
                        lblEv4.ForeColor = Color.Lime;
                        lblEv4.Text = "Proximo evento...";
                    }
                }
            }
            else
            {
                lblEv4.ForeColor = Color.Red;
                lblEv4.Text = "Sin evento...";
            }

            MySqlDataReader readerEv5 = a.devolverDatosEventos(5);
            if (readerEv5.HasRows)
            {
                while (readerEv5.Read())
                {
                    string numLocal = readerEv5[0].ToString();
                    string numVis = readerEv5[2].ToString();
                    string nomVis = a.obtenerNombreDeJugador(int.Parse(numVis));
                    string nomLocal = a.obtenerNombreDeJugador(int.Parse(numLocal));
                    lblLocalEv5.Text = nomLocal;
                    lblVisitanteEv5.Text = nomVis;
                    lblFechaEv5.Text = readerEv5[4].ToString();
                    lblDeporteEv5.Text = readerEv5[5].ToString();
                    string fechaAux = readerEv5[4].ToString();
                    string fechaHoy = DateTime.Today.ToShortDateString();
                    if (fechaAux == fechaHoy)
                    {
                        lblEv5.ForeColor = Color.Lime;
                        lblEv5.Text = "En juego...";
                    }
                    else
                    {
                        lblEv5.ForeColor = Color.Lime;
                        lblEv5.Text = "Proximo evento...";
                    }
                }
            }
            else
            {
                lblEv5.ForeColor = Color.Red;
                lblEv5.Text = "Sin evento...";
            }

            MySqlDataReader readerEv6 = a.devolverDatosEventosEquipos(6);
            if (readerEv6.HasRows)
            {
                while (readerEv6.Read())
                {
                    string numLocal = readerEv6[1].ToString();
                    string numVis = readerEv6[3].ToString();
                    string nomSelVis = aa.obtenerNombreDeSeleccion(int.Parse(numVis));
                    string nomSelLocal = aa.obtenerNombreDeSeleccion(int.Parse(numLocal));
                    lblLocalEv6.Text = nomSelLocal;
                    lblVisitanteEv6.Text = nomSelVis;
                    lblFechaEv6.Text = readerEv6[0].ToString();
                    lblDeporteEv6.Text = readerEv6[5].ToString();
                    string fechaAux = readerEv6[0].ToString();
                    string fechaHoy = DateTime.Today.ToShortDateString();
                    if (fechaAux == fechaHoy)
                    {
                        lblEv6.ForeColor = Color.Lime;
                        lblEv6.Text = "En juego...";
                    }
                    else
                    {
                        lblEv6.ForeColor = Color.Lime;
                        lblEv6.Text = "Proximo evento...";
                    }
                }
            }
            else
            {
                lblEv6.ForeColor = Color.Red;
                lblEv6.Text = "Sin evento...";
            }

        }

    }
}
