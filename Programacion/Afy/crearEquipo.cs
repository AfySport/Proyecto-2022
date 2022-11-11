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
    public partial class crearEquipo : Form
    {
        public crearEquipo()
        {
            InitializeComponent();
        }

        private void crearEquipo_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true)
            {
                lblLigas.Enabled = true;
                cbxLigas.Enabled = true;
                btnCrear.Enabled = true;
                checkBox1.Enabled = false;
                label3.Enabled = true;
                txtPais.Enabled = true;
            } else
            {
                checkBox1.Enabled = true;
                lblLigas.Enabled = false;
                cbxLigas.Enabled = false;
                btnCrear.Enabled = false;
                label3.Enabled = false;
                txtPais.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                btnCrear.Enabled = true;
                checkBox2.Enabled = false;
            } else
            {
                checkBox2.Enabled = true;
                btnCrear.Enabled = false;
            }
        }

        private void cbxDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxDeporte_SelectionChangeCommitted(object sender, EventArgs e)
        {
            object s = cbxDeporte.SelectedItem;
            string deporte = Convert.ToString(s);
            DataTable ligas = new DataTable();
            AfyConsultaSQL a = new AfyConsultaSQL();
            ligas = a.ligas(ligas, deporte);
            cbxLigas.DataSource = ligas;
            cbxLigas.ValueMember = "nombre";
            cbxLigas.DisplayMember = "nombre";         
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            AfyConsultaSQL afy = new AfyConsultaSQL();
            object aux1;
            object aux2;
            string deporte;
            string tipo, pais = txtPais.Text;
            string nombre = txtNombre.Text;
            if (checkBox1.Checked == true)
            {
                aux1 = cbxDeporte.SelectedItem;
                deporte = Convert.ToString(aux1);
                tipo = "Seleccion";
                string resultado = afy.crearSeleccion(deporte, nombre, tipo);
                if (resultado == "ok")
                {
                    MessageBox.Show("Seleccion creada correctamente");
                    txtNombre.Text = "";
                    cbxDeporte.Text = "";
                    cbxLigas.Text = "";
                }
                else
                {
                    MessageBox.Show("Error, " + resultado);
                }
            }

            if (checkBox2.Checked == true)
            {
                aux1 = cbxLigas.SelectedValue;
                string liga = Convert.ToString(aux1);
                aux2 = cbxDeporte.SelectedItem;
                deporte = Convert.ToString(aux2);
                tipo = "Cuadro";
                string resultado = afy.crearCuadro(deporte, nombre, liga, tipo, pais);
                if (resultado == "ok")
                {
                    MessageBox.Show("Equipo creado correctamente");
                    txtNombre.Text = "";
                    txtPais.Text = "";
                }
                else
                {
                    MessageBox.Show("Error, " + resultado);
                }
            }
        }
    }
}
