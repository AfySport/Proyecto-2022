using MySql.Data.MySqlClient;
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
    public partial class eventosActivos : Form
    {
        public eventosActivos()
        {
            InitializeComponent();
        }

        AfySQL a = new AfySQL();
        private void eventosActivos_Load(object sender, EventArgs e)
        {
            AfyConsultaSQL a = new AfyConsultaSQL();
            MySqlDataReader readerEv1 = a.devolverDatosEventos(1);
            if (readerEv1.HasRows)
            {
                while (readerEv1.Read())
                {
                    string numLocal = readerEv1[0].ToString();
                    string numVis = readerEv1[2].ToString();
                    string nomVis = a.obtenerNombreDeJugador(int.Parse(numVis));
                    string nomLocal = a.obtenerNombreDeJugador(int.Parse(numLocal));
                    lblLocalEv1.Text = nomLocal;
                    lblVisitanteEv1.Text = nomVis;
                    lblFechaEv1.Text = readerEv1[4].ToString();
                    lblResultadoLocalEv1.Text = "[" + readerEv1[1].ToString() + "]";
                    lblResultadoEv1Vis.Text = "[" + readerEv1[3].ToString() + "]";
                    lblDeporteEv1.Text = readerEv1[5].ToString();
                    string fechaAux = readerEv1[4].ToString();
                    string fechaHoy = DateTime.Today.ToShortDateString();
                    if (fechaAux == fechaHoy)
                    {
                        lblEv1.ForeColor = Color.Lime;
                        lblEv1.Text = "EN JUEGO...";
                    }
                    else
                    {
                        lblEv1.ForeColor = Color.Lime;
                        lblEv1.Text = "POR JUGAR";
                        groupBox1.Enabled = false;
                    }
                }
            }
            else
            {
                lblEv1.ForeColor = Color.Red;
                lblEv1.Text = "SIN DATOS...";
            }

            MySqlDataReader readerEv2 = a.devolverDatosEventosEquipos(2);
            if (readerEv2.HasRows)
            {
                while (readerEv2.Read())
                {
                    AfySQL an = new AfySQL();
                    string fecha = readerEv2[0].ToString();
                    int idEquipo1_local = int.Parse(readerEv2[1].ToString());
                    int resultado_local = int.Parse(readerEv2[2].ToString());
                    int idEquipo2_visitante = int.Parse(readerEv2[3].ToString());
                    int resultado_visitante = int.Parse(readerEv2[4].ToString());
                    string deporte = readerEv2[5].ToString();
                    lblDeporteEv2.Text = deporte;
                    lblFechaEv2.Text = fecha;
                    lblResultadoEv2Vis.Text = readerEv2[4].ToString();
                    lblResultadoLocalEv2.Text = readerEv2[2].ToString();
                    string nombreLocal = an.nombreDeSeleccion(idEquipo1_local);
                    string nombreVis = an.nombreDeSeleccion(idEquipo2_visitante);
                    lblLocalEv2.Text = nombreLocal;
                    lblVisitanteEv2.Text = nombreVis;
                    string fechaAux = DateTime.Today.ToShortDateString();
                    if (fecha == fechaAux)
                    {
                        lblEv2.ForeColor = Color.Lime;
                        lblEv2.Text = "EN JUEGO...";
                    }
                    else
                    {
                        lblEv2.ForeColor = Color.Lime;
                        lblEv2.Text = "POR JUGAR";
                        groupBox2.Enabled = false;
                    }
                }
            } else
            {
                lblEv2.ForeColor = Color.Red;
                lblEv2.Text = "SIN DATOS...";
            }

            MySqlDataReader readerEv3 = a.devolverDatosEventosEquipos(3);
            if (readerEv3.HasRows)
            {
                while (readerEv3.Read())
                {
                    AfySQL an = new AfySQL();
                    string fecha = readerEv3[0].ToString();
                    int idEquipo1_local = int.Parse(readerEv3[1].ToString());
                    int resultado_local = int.Parse(readerEv3[2].ToString());
                    int idEquipo2_visitante = int.Parse(readerEv3[3].ToString());
                    int resultado_visitante = int.Parse(readerEv3[4].ToString());
                    string deporte = readerEv3[5].ToString();
                    lblDeporteEv3.Text = deporte;
                    lblFechaEv3.Text = fecha;
                    lblResultadoEv3Vis.Text = readerEv3[4].ToString();
                    lblResultadoLocalEv3.Text = readerEv3[2].ToString();
                    string nombreLocal = an.nombreDeSeleccion(idEquipo1_local);
                    string nombreVis = an.nombreDeSeleccion(idEquipo2_visitante);
                    lblLocalEv3.Text = nombreLocal;
                    lblVisitanteEv3.Text = nombreVis;
                    string fechaAux = DateTime.Today.ToShortDateString();
                    if (fecha == fechaAux)
                    {
                        lblEv3.ForeColor = Color.Lime;
                        lblEv3.Text = "EN JUEGO...";
                    }
                    else
                    {
                        lblEv3.ForeColor = Color.Lime;
                        lblEv3.Text = "POR JUGAR";
                        groupBox3.Enabled = false;
                    }
                }
            }
            else
            {
                lblEv3.ForeColor = Color.Red;
                lblEv3.Text = "SIN DATOS...";
            }

            MySqlDataReader readerEv4 = a.devolverDatosEventos(4);
            if (readerEv4.HasRows)
            {
                while (readerEv4.Read())
                {
                    string numLocal = readerEv4[0].ToString();
                    string numVis = readerEv4[2].ToString();
                    string nomVis = a.obtenerNombreDeJugador(int.Parse(numVis));
                    string nomLocal = a.obtenerNombreDeJugador(int.Parse(numLocal));
                    lblLocalEv4.Text = nomLocal;
                    lblVisitanteEv4.Text = nomVis;
                    lblFechaEv4.Text = readerEv4[4].ToString();
                    lblResultadoEv4Local.Text = "[" + readerEv4[1].ToString() + "]";
                    lblResultadoEv4Vis.Text = "[" + readerEv4[3].ToString() + "]";
                    lblDeporteEv4.Text = readerEv4[5].ToString();
                    string fechaAux = readerEv4[4].ToString();
                    string fechaHoy = DateTime.Today.ToShortDateString();
                    if (fechaAux == fechaHoy)
                    {
                        lblEv4.ForeColor = Color.Lime;
                        lblEv4.Text = "EN JUEGO...";
                    }
                    else
                    {
                        lblEv4.ForeColor = Color.Lime;
                        lblEv4.Text = "POR JUGAR...";
                        groupBox4.Enabled = false;
                    }
                }
            }
            else
            {
                lblEv4.ForeColor = Color.Red;
                lblEv4.Text = "Sin evento...";
            }

            MySqlDataReader readerEv5 = a.devolverDatosEventos(5);
            if (readerEv5.HasRows)
            {
                while (readerEv5.Read())
                {
                    string numLocal = readerEv5[0].ToString();
                    string numVis = readerEv5[2].ToString();
                    string nomVis = a.obtenerNombreDeJugador(int.Parse(numVis));
                    string nomLocal = a.obtenerNombreDeJugador(int.Parse(numLocal));
                    lblLocalEv5.Text = nomLocal;
                    lblVisitanteEv5.Text = nomVis;
                    lblFechaEv5.Text = readerEv5[4].ToString();
                    lblDeporteEv5.Text = readerEv5[5].ToString();
                    string fechaAux = readerEv5[4].ToString();
                    string fechaHoy = DateTime.Today.ToShortDateString();
                    if (fechaAux == fechaHoy)
                    {
                        lblEv5.ForeColor = Color.Lime;
                        lblEv5.Text = "EN JUEGO...";
                    }
                    else
                    {
                        lblEv5.ForeColor = Color.Lime;
                        lblEv5.Text = "POR JUGAR...";
                        groupBox5.Enabled = false;
                    }
                }
            }
            else
            {
                lblEv5.ForeColor = Color.Red;
                lblEv5.Text = "Sin evento...";
            }

            MySqlDataReader readerEv6 = a.devolverDatosEventosEquipos(6);
            if (readerEv6.HasRows)
            {
                while (readerEv6.Read())
                {
                    AfySQL an = new AfySQL();
                    string fecha = readerEv6[0].ToString();
                    int idEquipo1_local = int.Parse(readerEv6[1].ToString());
                    int resultado_local = int.Parse(readerEv6[2].ToString());
                    int idEquipo2_visitante = int.Parse(readerEv6[3].ToString());
                    int resultado_visitante = int.Parse(readerEv6[4].ToString());
                    string deporte = readerEv6[5].ToString();
                    lblDeporteEv6.Text = deporte;
                    lblFechaEv6.Text = fecha;
                    lblResultadoEv6Vis.Text = readerEv6[4].ToString();
                    lblResultadoLocalEv6.Text = readerEv6[2].ToString();
                    string nombreLocal = an.nombreDeSeleccion(idEquipo1_local);
                    string nombreVis = an.nombreDeSeleccion(idEquipo2_visitante);
                    lblLocalEv6.Text = nombreLocal;
                    lblVisitanteEv6.Text = nombreVis;
                    string fechaAux = DateTime.Today.ToShortDateString();
                    if (fecha == fechaAux)
                    {
                        lblEv6.ForeColor = Color.Lime;
                        lblEv6.Text = "EN JUEGO...";
                    }
                    else
                    {
                        lblEv6.ForeColor = Color.Lime;
                        lblEv6.Text = "POR JUGAR";
                        groupBox6.Enabled = false;
                    }
                }
            }
            else
            {
                lblEv6.ForeColor = Color.Red;
                lblEv6.Text = "SIN DATOS...";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTantolocalEv1.Text) && !string.IsNullOrEmpty(txtTantoVisitanteEv1.Text))
            {
                MessageBox.Show("Ingrese solo el valor del local.");
            }
            else
            {
                if (string.IsNullOrEmpty(txtTantolocalEv1.Text))
                {
                    MessageBox.Show("Ingrese algún valor.");
                }
                else
                {
                    AfyConsultaSQL a = new AfyConsultaSQL();
                    a.actualizarValorEvento(1, "local", int.Parse(txtTantolocalEv1.Text));
                    MessageBox.Show("Valor actualizado correctamente");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTantoVisitanteEv1.Text) && !string.IsNullOrEmpty(txtTantolocalEv1.Text))
            {
                MessageBox.Show("Ingrese solo el valor del visitante.");
            } else
            {
                if (string.IsNullOrEmpty(txtTantoVisitanteEv1.Text))
                {
                    MessageBox.Show("Ingrese algún valor.");
                } else
                {
                    AfyConsultaSQL a = new AfyConsultaSQL();
                    a.actualizarValorEvento(1, "visitante", int.Parse(txtTantoVisitanteEv1.Text));
                    MessageBox.Show("Valor actualizado correctamente");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTantolocalEv4.Text) && !string.IsNullOrEmpty(txtTantoVisitanteEv4.Text))
            {
                MessageBox.Show("Ingrese solo el valor del local.");
            }
            else
            {
                if (string.IsNullOrEmpty(txtTantolocalEv4.Text))
                {
                    MessageBox.Show("Ingrese algún valor.");
                }
                else
                {
                    AfySQL a = new AfySQL();
                    a.actualizarValorEvento(4, "local", int.Parse(txtTantolocalEv4.Text));
                    MessageBox.Show("Valor actualizado correctamente");
                }
            }
        }

        private void btnActualizarLocalEv2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTantolocalEv2.Text) && !string.IsNullOrEmpty(txtTantoVisitanteEv2.Text))
            {
                MessageBox.Show("Ingrese solo el valor del local.");
            }
            else
            {
                if (string.IsNullOrEmpty(txtTantolocalEv2.Text))
                {
                    MessageBox.Show("Ingrese algún valor.");
                }
                else
                {
                    AfySQL a = new AfySQL();
                    a.actualizarValorEventoEquipos(2, "local", int.Parse(txtTantolocalEv2.Text));
                    MessageBox.Show("Valor actualizado correctamente");
                }
            }
        }

        private void btnActualizarVisEv4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTantoVisitanteEv4.Text) && !string.IsNullOrEmpty(txtTantolocalEv4.Text))
            {
                MessageBox.Show("Ingrese solo el valor del visitante.");
            }
            else
            {
                if (string.IsNullOrEmpty(txtTantoVisitanteEv4.Text))
                {
                    MessageBox.Show("Ingrese algún valor.");
                }
                else
                {
                    AfySQL a = new AfySQL();
                    a.actualizarValorEvento(4, "visitante", int.Parse(txtTantoVisitanteEv4.Text));
                    MessageBox.Show("Valor actualizado correctamente");
                }
            }
        }

        private void btnActualizarVisEv5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTantoVisitanteEv5.Text) && !string.IsNullOrEmpty(txtTantolocalEv5.Text))
            {
                MessageBox.Show("Ingrese solo el valor del visitante.");
            }
            else
            {
                if (string.IsNullOrEmpty(txtTantoVisitanteEv5.Text))
                {
                    MessageBox.Show("Ingrese algún valor.");
                }
                else
                {
                    AfySQL a = new AfySQL();
                    a.actualizarValorEvento(5, "visitante", int.Parse(txtTantoVisitanteEv5.Text));
                    MessageBox.Show("Valor actualizado correctamente");
                }
            }
        }

        private void btnActualizarLocalEv5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTantolocalEv5.Text) && !string.IsNullOrEmpty(txtTantoVisitanteEv5.Text))
            {
                MessageBox.Show("Ingrese solo el valor del local.");
            }
            else
            {
                if (string.IsNullOrEmpty(txtTantolocalEv5.Text))
                {
                    MessageBox.Show("Ingrese algún valor.");
                }
                else
                {
                    AfySQL a = new AfySQL();
                    a.actualizarValorEvento(5, "local", int.Parse(txtTantolocalEv5.Text));
                    MessageBox.Show("Valor actualizado correctamente");
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DialogResult equipo = MessageBox.Show("¿Seguro que desea eliminar el evento 1?", "Eliminacion de equipos", MessageBoxButtons.YesNo);
            if(equipo == DialogResult.Yes)
            {
                a.borrarFila(1, 1);
                MessageBox.Show("Evento eliminado correctamente, vuelva a entrar para actualizar.");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            DialogResult equipo = MessageBox.Show("¿Seguro que desea eliminar el evento 2?", "Eliminacion de equipos", MessageBoxButtons.YesNo);
            if (equipo == DialogResult.Yes)
            {
                a.borrarFila(2, 2);
                MessageBox.Show("Evento eliminado correctamente, vuelva a entrar para actualizar.");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            DialogResult equipo = MessageBox.Show("¿Seguro que desea eliminar el evento 3?", "Eliminacion de equipos", MessageBoxButtons.YesNo);
            if (equipo == DialogResult.Yes)
            {
                a.borrarFila(3, 2);
                MessageBox.Show("Evento eliminado correctamente, vuelva a entrar para actualizar.");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            DialogResult equipo = MessageBox.Show("¿Seguro que desea eliminar el evento 4?", "Eliminacion de equipos", MessageBoxButtons.YesNo);
            if (equipo == DialogResult.Yes)
            {
                a.borrarFila(4, 1);
                MessageBox.Show("Evento eliminado correctamente, vuelva a entrar para actualizar.");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            DialogResult equipo = MessageBox.Show("¿Seguro que desea eliminar el evento 5?", "Eliminacion de equipos", MessageBoxButtons.YesNo);
            if (equipo == DialogResult.Yes)
            {
                a.borrarFila(5, 1);
                MessageBox.Show("Evento eliminado correctamente, vuelva a entrar para actualizar.");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            DialogResult equipo = MessageBox.Show("¿Seguro que desea eliminar el evento 6?", "Eliminacion de equipos", MessageBoxButtons.YesNo);
            if (equipo == DialogResult.Yes)
            {
                a.borrarFila(6, 2);
                MessageBox.Show("Evento eliminado correctamente, vuelva a entrar para actualizar.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AfyConsultaSQL aa = new AfyConsultaSQL();
            bool ev1 = aa.hayEvento(1);
            if (ev1 == true)
            {
                MySqlDataReader readerEv1 = a.devolverDatosEventos(1);
                while (readerEv1.Read())
                {
                    string fecha = readerEv1[4].ToString();
                    int idjugador1_local = int.Parse(readerEv1[0].ToString());
                    int resultado_jugador1 = int.Parse(readerEv1[1].ToString());
                    int idjugador2_visitante = int.Parse(readerEv1[2].ToString());
                    int resultado_jugador2 = int.Parse(readerEv1[3].ToString());
                    string deporte = readerEv1[5].ToString();
                    int idBorrar = 1;
                    a.crearEventoIndividual(fecha, idjugador1_local, resultado_jugador1, idjugador2_visitante, resultado_jugador2, deporte, idBorrar);
                    MessageBox.Show("Evento guardado correctamente. Vuelva a entrar para actualizar");
                }
            }
            else
            {
                MessageBox.Show("No hay ningún evento creado en el slot 2");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AfyConsultaSQL aa = new AfyConsultaSQL();
            bool ev1 = aa.hayEventoEquipos(2);
            if (ev1 == true)
            {
                MySqlDataReader readerEv1 = a.devolverDatosEventosEquipos(2);
                while (readerEv1.Read())
                {
                    string fecha = readerEv1[0].ToString();
                    int idEquipo1_local = int.Parse(readerEv1[1].ToString());
                    int resultado_local = int.Parse(readerEv1[2].ToString());
                    int idEquipo2_visitante = int.Parse(readerEv1[3].ToString());
                    int resultado_visitante = int.Parse(readerEv1[4].ToString());
                    string deporte = readerEv1[5].ToString();
                    int idBorrar = 2;
                    a.crearEventoEquipos(fecha, idEquipo1_local, resultado_local, idEquipo2_visitante, resultado_visitante, deporte, idBorrar);
                    MessageBox.Show("Evento guardado correctamente. Vuelva a entrar para actualizar");
                }
            }
            else
            {
                MessageBox.Show("No hay ningún evento creado en el slot 2");
            }
        }

        private void btnActualizarVisEv2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTantoVisitanteEv2.Text) && !string.IsNullOrEmpty(txtTantolocalEv2.Text))
            {
                MessageBox.Show("Ingrese solo el valor del visitante.");
            }
            else
            {
                if (string.IsNullOrEmpty(txtTantoVisitanteEv2.Text))
                {
                    MessageBox.Show("Ingrese algún valor.");
                }
                else
                {
                    AfySQL a = new AfySQL();
                    a.actualizarValorEventoEquipos(2, "visitante", int.Parse(txtTantoVisitanteEv2.Text));
                    MessageBox.Show("Valor actualizado correctamente");
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AfyConsultaSQL aa = new AfyConsultaSQL();
            bool ev1 = aa.hayEventoEquipos(3);
            if (ev1 == true)
            {
                MySqlDataReader readerEv1 = a.devolverDatosEventosEquipos(3);
                while (readerEv1.Read())
                {
                    string fecha = readerEv1[0].ToString();
                    int idEquipo1_local = int.Parse(readerEv1[1].ToString());
                    int resultado_local = int.Parse(readerEv1[2].ToString());
                    int idEquipo2_visitante = int.Parse(readerEv1[3].ToString());
                    int resultado_visitante = int.Parse(readerEv1[4].ToString());
                    string deporte = readerEv1[5].ToString();
                    int idBorrar = 3;
                    a.crearEventoEquipos(fecha, idEquipo1_local, resultado_local, idEquipo2_visitante, resultado_visitante, deporte, idBorrar);
                }
            }
            else
            {
                MessageBox.Show("No hay ningún evento creado en el slot 3");
            }
        }

        private void btnActualizarLocalEv3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTantolocalEv3.Text) && !string.IsNullOrEmpty(txtTantoVisitanteEv3.Text))
            {
                MessageBox.Show("Ingrese solo el valor del local.");
            }
            else
            {
                if (string.IsNullOrEmpty(txtTantolocalEv3.Text))
                {
                    MessageBox.Show("Ingrese algún valor.");
                }
                else
                {
                    AfySQL a = new AfySQL();
                    a.actualizarValorEventoEquipos(3, "local", int.Parse(txtTantolocalEv3.Text));
                    MessageBox.Show("Valor actualizado correctamente");
                }
            }
        }

        private void btnActualizarVisEv3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTantoVisitanteEv3.Text) && !string.IsNullOrEmpty(txtTantolocalEv3.Text))
            {
                MessageBox.Show("Ingrese solo el valor del visitante.");
            }
            else
            {
                if (string.IsNullOrEmpty(txtTantoVisitanteEv3.Text))
                {
                    MessageBox.Show("Ingrese algún valor.");
                }
                else
                {
                    AfySQL a = new AfySQL();
                    a.actualizarValorEventoEquipos(3, "visitante", int.Parse(txtTantoVisitanteEv3.Text));
                    MessageBox.Show("Valor actualizado correctamente");
                }
            }
        }

        private void btnActualizarLocalEv6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTantolocalEv6.Text) && !string.IsNullOrEmpty(txtTantoVisitanteEv6.Text))
            {
                MessageBox.Show("Ingrese solo el valor del local.");
            }
            else
            {
                if (string.IsNullOrEmpty(txtTantolocalEv6.Text))
                {
                    MessageBox.Show("Ingrese algún valor.");
                }
                else
                {
                    AfySQL a = new AfySQL();
                    a.actualizarValorEventoEquipos(6, "local", int.Parse(txtTantolocalEv6.Text));
                    MessageBox.Show("Valor actualizado correctamente");
                }
            }
        }

        private void btnActualizarVisEv6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTantoVisitanteEv6.Text) && !string.IsNullOrEmpty(txtTantolocalEv6.Text))
            {
                MessageBox.Show("Ingrese solo el valor del visitante.");
            }
            else
            {
                if (string.IsNullOrEmpty(txtTantoVisitanteEv6.Text))
                {
                    MessageBox.Show("Ingrese algún valor.");
                }
                else
                {
                    AfySQL a = new AfySQL();
                    a.actualizarValorEventoEquipos(6, "visitante", int.Parse(txtTantoVisitanteEv6.Text));
                    MessageBox.Show("Valor actualizado correctamente");
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            AfyConsultaSQL aa = new AfyConsultaSQL();
            bool ev1 = aa.hayEventoEquipos(6);
            if (ev1 == true)
            {
                MySqlDataReader readerEv1 = a.devolverDatosEventosEquipos(6);
                while (readerEv1.Read())
                {
                    string fecha = readerEv1[0].ToString();
                    int idEquipo1_local = int.Parse(readerEv1[1].ToString());
                    int resultado_local = int.Parse(readerEv1[2].ToString());
                    int idEquipo2_visitante = int.Parse(readerEv1[3].ToString());
                    int resultado_visitante = int.Parse(readerEv1[4].ToString());
                    string deporte = readerEv1[5].ToString();
                    int idBorrar = 6;
                    a.crearEventoEquipos(fecha, idEquipo1_local, resultado_local, idEquipo2_visitante, resultado_visitante, deporte, idBorrar);
                    MessageBox.Show("Evento guardado correctamente. Vuelva a entrar para actualizar");
                }
            }
            else
            {
                MessageBox.Show("No hay ningún evento creado en el slot 6");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AfyConsultaSQL aa = new AfyConsultaSQL();
            bool ev1 = aa.hayEvento(4);
            if (ev1 == true)
            {
                MySqlDataReader readerEv1 = a.devolverDatosEventos(4);
                while (readerEv1.Read())
                {
                    string fecha = readerEv1[4].ToString();
                    int idjugador1_local = int.Parse(readerEv1[0].ToString());
                    int resultado_jugador1 = int.Parse(readerEv1[1].ToString());
                    int idjugador2_visitante = int.Parse(readerEv1[2].ToString());
                    int resultado_jugador2 = int.Parse(readerEv1[3].ToString());
                    string deporte = readerEv1[5].ToString();
                    int idBorrar = 4;
                    a.crearEventoIndividual(fecha, idjugador1_local, resultado_jugador1, idjugador2_visitante, resultado_jugador2, deporte, idBorrar);
                    MessageBox.Show("Evento guardado correctamente. Vuelva a entrar para actualizar");
                }
            }
            else
            {
                MessageBox.Show("No hay ningún evento creado en el slot 4");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            AfyConsultaSQL aa = new AfyConsultaSQL();
            bool ev1 = aa.hayEvento(5);
            if (ev1 == true)
            {
                MySqlDataReader readerEv1 = a.devolverDatosEventos(5);
                while (readerEv1.Read())
                {
                    string fecha = readerEv1[4].ToString();
                    int idjugador1_local = int.Parse(readerEv1[0].ToString());
                    int resultado_jugador1 = int.Parse(readerEv1[1].ToString());
                    int idjugador2_visitante = int.Parse(readerEv1[2].ToString());
                    int resultado_jugador2 = int.Parse(readerEv1[3].ToString());
                    string deporte = readerEv1[5].ToString();
                    int idBorrar = 5;
                    a.crearEventoIndividual(fecha, idjugador1_local, resultado_jugador1, idjugador2_visitante, resultado_jugador2, deporte, idBorrar);
                    MessageBox.Show("Evento guardado correctamente. Vuelva a entrar para actualizar");
                }
            }
            else
            {
                MessageBox.Show("No hay ningún evento creado en el slot 4");
            }
        }
    }
}
