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
            AfyPublicidad afyp = new AfyPublicidad();
            int maximo = afyp.publicidadMostrar.Images.Count;
            tiempo++;
            lblContador.Text = tiempo.ToString();           
            if (lblContador.Text == "20")
            {
                Random r = new Random();
                azar1 = r.Next(1, maximo);
                azar2 = r.Next(1, maximo);
                pb1.Image = afyp.publicidadMostrar.Images[azar1];
                pb2.Image = afyp.publicidadMostrar.Images[azar2];
                temporizador.Enabled = false;
                tiempo = 0;
                lblContador.Text = "0";
                temporizador.Start();
            }
        }

        private void cambiarDeIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
