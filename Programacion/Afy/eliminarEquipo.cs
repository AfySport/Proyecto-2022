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
    public partial class eliminarEquipo : Form
    {
        public eliminarEquipo()
        {
            InitializeComponent();
        }

        private void cbxLigas_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Enabled = false;
                object s = comboBox1.SelectedItem;
                string deporte = Convert.ToString(s);
                DataTable ligas = new DataTable();
                AfyConsultaSQL a = new AfyConsultaSQL();
                ligas = a.ligasDisponibles(ligas, deporte);
                cbxLigas.DataSource = ligas;
                cbxLigas.ValueMember = "nombreLiga";
                cbxLigas.DisplayMember = "nombreLiga";
            }
            if (checkBox2.Checked == true)
            {
                object s = comboBox1.SelectedItem;
                string deporte = Convert.ToString(s);
                DataTable paises = new DataTable();
                AfyConsultaSQL a = new AfyConsultaSQL();
                paises = a.seleccionesConDisciplinas(deporte, paises);
                if (paises.Rows.Count > 0)
                {
                    cbxSeleccion.DataSource = paises;
                    cbxSeleccion.ValueMember = "nombre";
                    cbxSeleccion.DisplayMember = "nombre";
                }
                else
                {
                    cbxSeleccion.DataSource = null;
                    cbxSeleccion.Items.Clear();
                    cbxSeleccion.Text = "(Sin datos)";
                }
                checkBox1.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                checkBox2.Enabled = false;
                cbxLigas.Visible = true;
                cbxEquipos.Visible = true;
            } else
            {
                checkBox2.Enabled = true;
                cbxLigas.Visible = false;
                cbxEquipos.Visible = false;
                label4.Text = "";
                txtIdEliminar.Visible = false;
                button2.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true)
            {
                checkBox1.Enabled = false;
                cbxSeleccion.Visible = true;
            } else
            {
                checkBox1.Enabled = true;
                cbxSeleccion.Visible = false;
                label4.Text = "";
                txtIdEliminar.Visible = false;
                button2.Visible = false;
            }
        }

        private void cbxLigas_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            object s = cbxLigas.SelectedValue;
            string deporte = Convert.ToString(s);
            DataTable equipos = new DataTable();
            AfyConsultaSQL a = new AfyConsultaSQL();
            equipos = a.equiposDeLigas(deporte, equipos);
            cbxEquipos.DataSource = equipos;
            cbxEquipos.ValueMember = "nombre";
            cbxEquipos.DisplayMember = "nombre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                object aux1 = cbxEquipos.SelectedValue;
                string equipo = Convert.ToString(aux1);
                aux1 = comboBox1.SelectedItem;
                string disciplina = Convert.ToString(aux1);
                AfyConsultaSQL a = new AfyConsultaSQL();
                DataTable tabla = new DataTable();
                tabla = a.consultarJugadoresEquipos(equipo, disciplina, tabla);
                if(tabla == null)
                {
                    MessageBox.Show("Complete todos los campos");
                } else
                {
                    if (tabla.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = tabla;
                        label4.Text = "idCuadro a eliminar";
                        txtIdEliminar.Visible = true;
                        button2.Visible = true;
                    }
                    else
                    {
                        dataGridView1.DataSource = "";
                        MessageBox.Show("No hay jugadores.");
                        txtIdEliminar.Visible = true;
                        button2.Visible = true;
                    }
                }
            }
            if (checkBox2.Checked == true)
            {
                object aux1 = cbxSeleccion.SelectedValue;
                string seleccion = Convert.ToString(aux1);
                aux1 = comboBox1.SelectedItem;
                string disciplina = Convert.ToString(aux1);
                AfyConsultaSQL a = new AfyConsultaSQL();
                DataTable tabla = new DataTable();
                tabla = a.mostrarJugadoresSeleccion(seleccion, disciplina, tabla);
                if (tabla.Rows.Count > 0)
                {
                    dataGridView1.DataSource = tabla;
                    label4.Text = "idSeleccion a eliminar";
                    txtIdEliminar.Visible = true;
                    button2.Visible = true;
                }
                else
                {
                    dataGridView1.DataSource = "";
                    MessageBox.Show("No hay jugadores.");
                    txtIdEliminar.Visible = true;
                    button2.Visible = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AfyConsultaSQL a = new AfyConsultaSQL();
            DialogResult equipo = MessageBox.Show("¿Seguro que desea eliminar el equipo?", "Eliminacion de equipos", MessageBoxButtons.YesNo);
            if(equipo == DialogResult.Yes)
            {
                if (checkBox1.Checked == true)
                {
                    object aux = cbxEquipos.SelectedValue;
                    string nomEquipo = Convert.ToString(aux);
                    aux = cbxLigas.SelectedValue;
                    string nomLiga = Convert.ToString(aux);
                    aux = comboBox1.SelectedItem;
                    string disciplina = Convert.ToString(aux);
                    int id = int.Parse(txtIdEliminar.Text);
                    string resultado = a.eliminarCuadro(id, disciplina, nomEquipo, nomLiga);
                    if (resultado == "ok")
                    {
                        MessageBox.Show("Equipo eliminado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error " + resultado);
                    }
                }
                if (checkBox2.Checked == true)
                {                    
                    object aux = cbxSeleccion.SelectedValue;
                    string nomSeleccion = Convert.ToString(aux);
                    aux = comboBox1.SelectedItem;
                    string disciplina = Convert.ToString(aux);
                    int id = int.Parse(txtIdEliminar.Text);
                    string resultado = a.eliminarSeleccion(id, nomSeleccion, disciplina);
                    if (resultado == "ok")
                    {
                        MessageBox.Show("Selección eliminada correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error " + resultado);
                    }
                }
            }
        }
    }
}
