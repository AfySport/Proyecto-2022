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
    public partial class AfyPanelEventos : Form
    {
        public AfyPanelEventos()
        {
            InitializeComponent();
            mostrarForm(new inicioPanel());
        }

        private void AfyPanelEventos_Load(object sender, EventArgs e)
        {
            btnInicio_Click(null, e);
        }

        private void mostrarForm(object form)
        {
            if(this.pnlFormMostrar.Controls.Count > 0)
            {
                this.pnlFormMostrar.Controls.RemoveAt(0);
            }
            Form formulario = form as Form; //Convierto el objeto a formulario
            formulario.TopLevel = false; //Indico que es un formulario secundario
            formulario.Dock = DockStyle.Fill; //Que se rellene en el panel contenedor
            this.pnlFormMostrar.Controls.Add(formulario);
            formulario.Show();
        }

        private void btnCrearEvento_Click(object sender, EventArgs e)
        {
            mostrarForm(new crearEventos());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarForm(new consultarEventos());
        }

        private void btnCrearJugador_Click(object sender, EventArgs e)
        {
            mostrarForm(new crearJugador());
        }

        private void btnConsultarJugador_Click(object sender, EventArgs e)
        {
            mostrarForm(new consultarJugador());
        }

        private void AfyPanelEventos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCrearEquipo_Click(object sender, EventArgs e)
        {
            mostrarForm(new crearEquipo());
        }

        private void btnConsultarEquipo_Click(object sender, EventArgs e)
        {
            mostrarForm(new consultarEquipos());
        }

        private void btnEventosActivos_Click(object sender, EventArgs e)
        {
            mostrarForm(new eventosActivos());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mostrarForm(new eliminarJugador());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostrarForm(new eliminarEquipo());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mostrarForm(new crearLiga());
        }

        private void pnlOpciones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            mostrarForm(new inicioPanel());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AfyAdmin a = new AfyAdmin();
            a.Show();
            this.Hide();
        }
    }
}
