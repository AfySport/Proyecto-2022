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
    public partial class crearLiga : Form
    {
        public crearLiga()
        {
            InitializeComponent();
        }

        private void crearLiga_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            object aux = cbxDeporte.SelectedItem;
            string deporte = Convert.ToString(aux);
            string nombre = txtNombre.Text, pais = txtPais.Text;
            AfyConsultaSQL afy = new AfyConsultaSQL();
            string resultado = afy.crearLiga(nombre, deporte, pais);
            if(resultado == "ok")
            {
                MessageBox.Show("Liga creada correctamente.");
            } else
            {
                MessageBox.Show("Error, " + resultado);
            }
        }
    }
}
