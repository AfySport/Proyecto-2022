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
                pb1.Visible = true;
                pb2.Visible = true;
                temporizador.Start();
                hacermeSuscriptorToolStripMenuItem.Visible = true;
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
            if (lblContador.Text == "2")
            {                
                Random r = new Random();
                azar1 = r.Next(1, maximo);
                azar2 = r.Next(1, maximo);
                MemoryStream imagenAzar1 = afy.mostrarImagen(azar1);
                Bitmap bitmap = new Bitmap(imagenAzar1);
                MemoryStream imagenAzar2 = afy.mostrarImagen(azar2);
                Bitmap bitmap2 = new Bitmap(imagenAzar2);
                pb1.Image = bitmap;
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
    }
}
