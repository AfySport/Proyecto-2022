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
    public partial class AfyInformacionSuscribirse : Form
    {
        public AfyInformacionSuscribirse()
        {
            InitializeComponent();
            int idioma = Idioma.Tipoidioma;
            if (idioma == 1)
            {
                idiomaEspaniol();
            }
            else
            {
                idiomaIngles();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AfyNuevoSuscriptor a = new AfyNuevoSuscriptor();
            a.Show();
            this.Hide();
        }

        private void idiomaEspaniol()
        {
            Idioma.tipoidioma = 1;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            button1.Text = "Volver";
        }

        private void idiomaIngles()
        {
            Idioma.tipoidioma = 2;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            button1.Text = "Back";
        }

        private void AfyInformacionSuscribirse_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
