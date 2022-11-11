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
    public partial class eliminarJugador : Form
    {
        public eliminarJugador()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void cbxLigas_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AfyConsultaSQL a = new AfyConsultaSQL();
            object aux1;
            aux1 = comboBox1.SelectedItem;
            string rol = Convert.ToString(aux1);
            string nombre = txtNombre.Text, apellido = txtApellido.Text;
            DataTable tabla = new DataTable();
            
            if(string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("Complete todos los campos");
            } else
            {
                tabla = a.eliminarJugador(nombre, apellido, rol, tabla);
                if (tabla.Rows.Count > 0)
                {
                    dataGridView1.DataSource = tabla;
                    btnEliminar.Visible = true;
                }
                else
                {
                    dataGridView1.DataSource = "";
                    MessageBox.Show("No existe ningun jugador con los datos");
                }
            }                     
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult cuadro = MessageBox.Show("¿Seguro que desea eliminar al jugador?", "Eliminacion de jugadores", MessageBoxButtons.YesNo);
            if(cuadro == DialogResult.Yes)
            {
                int idEliminar = int.Parse(txtIdJugador.Text);
                string nombre = txtNombre.Text, apellido = txtApellido.Text;
                AfyConsultaSQL a = new AfyConsultaSQL();
                string resultado = a.borrarIdJugador(idEliminar, nombre, apellido);
                if (resultado == "ok")
                {
                    MessageBox.Show("Jugador eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("Error " + resultado);
                }
            }
        }
    }
}
