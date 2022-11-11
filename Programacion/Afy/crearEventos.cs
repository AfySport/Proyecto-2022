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
    public partial class crearEventos : Form
    {
        public crearEventos()
        {
            InitializeComponent();
        }

        private void crearEventos_Load(object sender, EventArgs e)
        {
            dtpFecha.MaxDate = DateTime.Today.AddYears(1);
            dtpFecha.MinDate = DateTime.Today;
            AfyConsultaSQL a = new AfyConsultaSQL();
            bool ev1 = a.hayEvento(1), ev4= a.hayEvento(4), ev5=a.hayEvento(5);
            bool ev2 = a.hayEventoEquipos(2), ev3 = a.hayEventoEquipos(3), ev6 = a.hayEventoEquipos(6);
            if(ev1 == true)
            {
                lblEv1.ForeColor = Color.Red;
                lblEv1.Text = "Ocupado";
            } else
            {
                lblEv1.ForeColor = Color.Green;
                lblEv1.Text = "Disponible";
            }
            if (ev2 == true)
            {
                lblEv2.ForeColor = Color.Red;
                lblEv2.Text = "Ocupado";
            }
            else
            {
                lblEv2.ForeColor = Color.Green;
                lblEv2.Text = "Disponible";
            }
            if (ev3 == true)
            {
                lblEv3.ForeColor = Color.Red;
                lblEv3.Text = "Ocupado";
            }
            else
            {
                lblEv3.ForeColor = Color.Green;
                lblEv3.Text = "Disponible";
            }
            if (ev4 == true)
            {
                lblEv4.ForeColor = Color.Red;
                lblEv4.Text = "Ocupado";
            }
            else
            {
                lblEv4.ForeColor = Color.Green;
                lblEv4.Text = "Disponible";
            }
            if (ev5 == true)
            {
                lblEv5.ForeColor = Color.Red;
                lblEv5.Text = "Ocupado";
            }
            else
            {
                lblEv5.ForeColor = Color.Green;
                lblEv5.Text = "Disponible";
            }
            if (ev6 == true)
            {
                lblEv6.ForeColor = Color.Red;
                lblEv6.Text = "Ocupado";
            }
            else
            {
                lblEv6.ForeColor = Color.Green;
                lblEv6.Text = "Disponible";
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxVisitante.Visible = true;
            label5.Visible = true;
        }

        private void cbxDeporte_SelectionChangeCommitted(object sender, EventArgs e)
        {
            object aux = cbxDeporte.SelectedItem;
            string disciplina = Convert.ToString(aux);
            AfySQL a = new AfySQL();
            DataTable selecciones_loc = new DataTable();
            selecciones_loc = a.seleccionesConDisciplina(disciplina, selecciones_loc);
            if(selecciones_loc.Rows.Count >= 2)
            {
                cbxLocal.DataSource = selecciones_loc;
                cbxLocal.ValueMember = "nombre";
                cbxLocal.DisplayMember = "nombre";
            } else
            {
                cbxLocal.DataSource = null;
                cbxLocal.Items.Clear();
                cbxVisitante.DataSource = null;
                cbxVisitante.Items.Clear();
                cbxLocal.Text = "(Sin datos)";
                cbxVisitante.Text = "(Sin datos)";
                MessageBox.Show("No existen al menos dos selecciones del deporte que eligió.");
            }
        }

        private void cbxLocal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            object aux = cbxLocal.SelectedValue;
            string nomSeleccionlocal = Convert.ToString(aux);
            aux = cbxDeporte.SelectedItem;
            string disciplina = Convert.ToString(aux);
            AfyConsultaSQL a = new AfyConsultaSQL();
            DataTable selecciones_vis = new DataTable();
            selecciones_vis = a.seleccionVisitante(nomSeleccionlocal, disciplina, selecciones_vis);
            cbxVisitante.DataSource = selecciones_vis;
            cbxVisitante.ValueMember = "nombre";
            cbxVisitante.DisplayMember = "nombre";
        }

        private void cbxDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fecha = dtpFecha.Value.ToShortDateString();
            
        }

        private void cbxDeporteInvidual_SelectionChangeCommitted(object sender, EventArgs e)
        {
            object aux = cbxDeporteInvidual.SelectedItem;
            string disciplina = Convert.ToString(aux);
            AfyConsultaSQL a = new AfyConsultaSQL();
            DataTable jugadores = new DataTable();
            jugadores = a.jugadoresInvidualLocal(disciplina, jugadores);
            if(jugadores.Rows.Count >= 2)
            {
                dataGridView1.DataSource = jugadores;
            } else
            {
                dataGridView1.DataSource = "";
                dataGridView1.Rows.Clear();
                MessageBox.Show("El deporte que se eligió no cuenta con 2 o más jugadores");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string aux = txtIdLocal.Text;            
            string nombre = txtNombreLocal.Text, apellido = txtApellidoLocal.Text;
            AfyConsultaSQL a = new AfyConsultaSQL();
            string resultado = a.comprobarCredencialesJugador(aux, nombre, apellido);
            if(resultado == "ok")
            {
                DataTable jugadoresVisitantes = new DataTable();
                object auxx = cbxDeporteInvidual.SelectedItem;
                string rol = Convert.ToString(auxx);
                int id = int.Parse(aux);
                jugadoresVisitantes = a.mostrarVisitantes(id, rol, jugadoresVisitantes);
                dataGridView2.DataSource = jugadoresVisitantes;
            } else
            {
                dataGridView2.DataSource = null;                
                MessageBox.Show(resultado);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AfyConsultaSQL a = new AfyConsultaSQL();       
            if(cbxIndividual.Checked == true)
            {
                if (txtIdVisitante.Text == txtIdLocal.Text && txtNombreLocal.Text == txtNombreVisitante.Text && txtApellidoLocal.Text == txtApellidoVisitante.Text)
                {
                    MessageBox.Show("Ingrese jugadores distintos.");
                }
                else
                {
                    string resultado = a.comprobarCredencialesJugador(txtIdVisitante.Text, txtNombreVisitante.Text, txtApellidoVisitante.Text);
                    if (resultado == "ok")
                    {
                        object aux = cbxDeporteInvidual.SelectedItem;
                        string deporte = Convert.ToString(aux);
                        string fecha = dtpFecha.Value.ToShortDateString();
                        DialogResult cuadro = MessageBox.Show("Datos del evento:\nLocal: " + txtNombreLocal.Text + " " + txtApellidoLocal.Text + "  vs  Visitante: " + txtNombreVisitante.Text + " " + txtApellidoVisitante.Text + "\nDatos del encuentro: " + deporte + " , " + fecha + "", "Evento");
                        MessageBox.Show("Ingrese donde quiere que esté asignado el evento.");
                        if (cbxIndividual.Checked == true)
                        {
                            button1.Visible = true;
                            button8.Visible = true;
                            button7.Visible = true;
                            lblEv2.Visible = true;
                            lblEv3.Visible = true;
                            lblEv6.Visible = true;
                        }
                        else
                        {
                            button1.Visible = false;
                            button8.Visible = false;
                            button7.Visible = false;
                            lblEv2.Visible = false;
                            lblEv3.Visible = false;
                            lblEv6.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(resultado);
                    }
                }
            } else
            {
                if(cbxSelecciones.Checked == true)
                {
                    object aux = cbxDeporteInvidual.SelectedItem;
                    string deporte = Convert.ToString(aux);
                    aux = cbxLocal.SelectedValue;
                    string nomSelLocal = Convert.ToString(aux);
                    aux = cbxVisitante.SelectedValue;
                    string nomSelVis = Convert.ToString(aux);
                    string fecha = dtpFecha.Value.ToShortDateString();
                    string alineacion_local = txtAlineacionLocal.Text;
                    string alineacion_vis = txtAlineacionVisitante.Text;
                    DialogResult cuadro = MessageBox.Show("Datos del evento:\nLocal: " + nomSelLocal + "  vs  Visitante: " + nomSelVis + "\nDatos del encuentro: " + deporte + " , " + fecha + "", "Evento");
                    MessageBox.Show("Ingrese donde quiere que esté asignado el evento.");
                    if (cbxSelecciones.Checked == true)
                    {
                        button4.Visible = true;
                        button5.Visible = true;
                        button6.Visible = true;
                        lblEv2.Visible = true;
                        lblEv3.Visible = true;
                        lblEv6.Visible = true;
                    }
                    else
                    {
                        button4.Visible = false;
                        button5.Visible = false;
                        button6.Visible = false;
                        lblEv2.Visible = false;
                        lblEv3.Visible = false;
                        lblEv6.Visible = false;
                    }                  
                }
            }          
        }

        private void cbxDeporteInvidual_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            object aux = cbxDeporteInvidual.SelectedItem;
            string deporte = Convert.ToString(aux);
            string fecha = dtpFecha.Value.ToShortDateString();
            AfyConsultaSQL a = new AfyConsultaSQL();
            a.crearEventoTablaAuxIndividual(1, int.Parse(txtIdLocal.Text), 0, int.Parse(txtIdVisitante.Text), 0,fecha, deporte);
            MessageBox.Show("Evento creado correctamente!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            object aux = cbxDeporteInvidual.SelectedItem;
            string deporte = Convert.ToString(aux);
            string fecha = dtpFecha.Value.ToShortDateString();
            AfyConsultaSQL a = new AfyConsultaSQL();
            a.crearEventoTablaAuxIndividual(5, int.Parse(txtIdLocal.Text), 0, int.Parse(txtIdVisitante.Text), 0, fecha, deporte);
            MessageBox.Show("Evento creado correctamente!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            object aux = cbxDeporte.SelectedItem;
            string deporte = Convert.ToString(aux);
            aux = cbxLocal.SelectedValue;
            string nomSelLocal = Convert.ToString(aux);
            aux = cbxVisitante.SelectedValue;
            string nomSelVis = Convert.ToString(aux);
            AfyConsultaSQL a = new AfyConsultaSQL();
            string fecha = dtpFecha.Value.ToShortDateString();
            a.crearEventoTablaAuxEquipos(6, fecha, nomSelLocal, txtAlineacionLocal.Text, 0, nomSelVis, txtAlineacionVisitante.Text, 0, deporte);
            MessageBox.Show("Evento creado correctamente!");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            object aux = cbxDeporte.SelectedItem;
            string deporte = Convert.ToString(aux);
            aux = cbxLocal.SelectedValue;
            string nomSelLocal = Convert.ToString(aux);
            aux = cbxVisitante.SelectedValue;
            string nomSelVis = Convert.ToString(aux);
            AfyConsultaSQL a = new AfyConsultaSQL();
            string fecha = dtpFecha.Value.ToShortDateString();
            a.crearEventoTablaAuxEquipos(2, fecha, nomSelLocal, txtAlineacionLocal.Text, 0, nomSelVis, txtAlineacionVisitante.Text, 0, deporte);
            MessageBox.Show("Evento creado correctamente!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            object aux = cbxDeporte.SelectedItem;
            string deporte = Convert.ToString(aux);
            aux = cbxLocal.SelectedValue;
            string nomSelLocal = Convert.ToString(aux);
            aux = cbxVisitante.SelectedValue;
            string nomSelVis = Convert.ToString(aux);
            AfyConsultaSQL a = new AfyConsultaSQL();
            string fecha = dtpFecha.Value.ToShortDateString();
            a.crearEventoTablaAuxEquipos(3, fecha, nomSelLocal, txtAlineacionLocal.Text, 0, nomSelVis, txtAlineacionVisitante.Text, 0, deporte);
            MessageBox.Show("Evento creado correctamente!");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            object aux = cbxDeporteInvidual.SelectedItem;
            string deporte = Convert.ToString(aux);
            string fecha = dtpFecha.Value.ToShortDateString();
            AfyConsultaSQL a = new AfyConsultaSQL();
            a.crearEventoTablaAuxIndividual(4, int.Parse(txtIdLocal.Text), 0, int.Parse(txtIdVisitante.Text), 0, fecha, deporte);
            MessageBox.Show("Evento creado correctamente!");
        }

        private void cbxSelecciones_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxSelecciones.Checked == true)
            {
                label3.Visible = true; 
                label2.Visible = true;
                cbxDeporte.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                cbxLocal.Visible = true;
                cbxVisitante.Visible = true;
                txtAlineacionLocal.Visible = true;
                txtAlineacionVisitante.Visible = true;
                label18.Visible = true;
                label6.Visible = true;
                dtpFecha.Visible = true;
                button3.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
            } else
            {
                label3.Visible = false;
                label2.Visible = false;
                cbxDeporte.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                cbxLocal.Visible = false;
                cbxVisitante.Visible = false;
                txtAlineacionLocal.Visible = false;
                txtAlineacionVisitante.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label18.Visible = false;
                label6.Visible = false;
                dtpFecha.Visible = false;
                button3.Visible = false;
                lblEv1.Visible = false;
                lblEv2.Visible = false;
                lblEv3.Visible = false;
                lblEv4.Visible = false;
                lblEv5.Visible = false;
                lblEv6.Visible = false;
                button1.Visible = false; 
                button4.Visible = false; 
                button5.Visible = false; 
                button8.Visible = false; 
                button7.Visible = false; 
                button6.Visible = false; 
            }
        }

        private void cbxIndividual_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxIndividual.Checked == true)
            {
                label10.Visible = true;
                cbxDeporteInvidual.Visible = true;
                label9.Visible = true;
                dataGridView1.Visible = true;
                label12.Visible = true;
                txtIdLocal.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                txtNombreLocal.Visible = true;
                txtApellidoLocal.Visible = true;
                button2.Visible = true;
                label11.Visible = true;
                dataGridView2.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                txtIdVisitante.Visible = true;
                txtNombreVisitante.Visible = true;
                txtApellidoVisitante.Visible = true;
                label6.Visible = true;
                dtpFecha.Visible = true;
                button3.Visible = true;
            } else
            {
                label10.Visible = false;
                cbxDeporteInvidual.Visible = false;
                label9.Visible = false;
                dataGridView1.Visible = false;
                label12.Visible = false;
                txtIdLocal.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                txtNombreLocal.Visible = false;
                txtApellidoLocal.Visible = false;
                button2.Visible = false;
                label11.Visible = false;
                dataGridView2.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                txtIdVisitante.Visible = false;
                txtNombreVisitante.Visible = false;
                txtApellidoVisitante.Visible = false;
                label6.Visible = false;
                dtpFecha.Visible = false;
                button3.Visible = false;
                lblEv1.Visible = false;
                lblEv2.Visible = false;
                lblEv3.Visible = false;
                lblEv4.Visible = false;
                lblEv5.Visible = false;
                lblEv6.Visible = false;
                button1.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button8.Visible = false;
                button7.Visible = false;
                button6.Visible = false;
            }
        }
    }
}
