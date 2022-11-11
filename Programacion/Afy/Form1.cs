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
    public partial class afyInicio : Form
    {
        public afyInicio()
        {
            InitializeComponent();
            int idioma = Idioma.Tipoidioma;
            if(idioma == 1)
            {
                idiomaEspanion();
            } else
            {
                idiomaIngles();
            }
        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            afyregistro afyr = new afyregistro();
            this.Hide();
            afyr.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            afylogin afyl = new afylogin();
            this.Hide();
            afyl.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void afyInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        private void idiomaIngles()
        {
            Idioma.tipoidioma = 2;
            btnIngresar.Text = "Join";
            btnSalir.Text = "Sign out";
            btnLogin.Text = "Sign In";
            btnRegistro.Text = "Sign Up";
            idiomaToolStripMenuItem.Text = "Language";
            españolToolStripMenuItem.Text = "Spanish";
            inglésToolStripMenuItem.Text = "English";            
        }

        private void idiomaEspanion()
        {
            Idioma.tipoidioma = 1;
            btnIngresar.Text = "Ingresar sin registrarme";
            btnSalir.Text = "Salir";
            btnLogin.Text = "Login";
            btnRegistro.Text = "Registrarme";
            idiomaToolStripMenuItem.Text = "Idioma";
            españolToolStripMenuItem.Text = "Español";
            inglésToolStripMenuItem.Text = "Inglés";           
        }

        private void inglésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Idioma.Tipoidioma == 1)
            {
                idiomaIngles();
                MessageBox.Show("Language changed successfully");
            } else
            {
                MessageBox.Show("Your language is already English");
            }

        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Idioma.Tipoidioma == 2)
            {
                idiomaEspanion();
                MessageBox.Show("Idioma cambiado correctamente."); 
            }
            else
            {
                MessageBox.Show("Su idioma ya es el español.");
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            AfySesion.tipo = "SinRegistro";
            MessageBox.Show("Ingreso sin cuenta");
            AfySport a = new AfySport();
            this.Hide();
            a.Show();
        }
    }
}
