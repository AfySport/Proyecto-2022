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
    public partial class crearJugador : Form
    {
        public crearJugador()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string fecha = dtpFecha.Value.ToShortDateString();
            string nombre = txtNombre.Text, apellido = txtApellido.Text;
            string auxx = txtEdad.Text;
            string edad = txtEdad.Text;
            object aux = cbxRol.SelectedItem;
            string rol = Convert.ToString(aux);
            string altura = txtAltura.Text, pais = txtPais.Text;
            string peso = txtPeso.Text;           
            AfyConsultaSQL a = new AfyConsultaSQL();
            string resultado = "";
            int tipo = 0;
            if (checkBox1.Checked == true)
            {
                tipo = 1;
                resultado = a.crearJugador(nombre, apellido, edad, fecha, rol, altura, peso, pais, "NO", "NO", tipo);
                limpiar();
            } else
            {
                if(checkBox2.Checked == true)
                {
                    tipo = 2;
                    object aux1 = cbxEquipos.SelectedValue;
                    string nombreCuadro = Convert.ToString(aux1);
                    resultado = a.crearJugador(nombre, apellido, edad, fecha, rol, altura, peso, pais, nombreCuadro, "NO", tipo);
                    limpiar();
                } else
                {
                    if (checkBox3.Checked == true)
                    {
                        tipo = 3;
                        object aux1 = cbxSelecciones.SelectedValue;
                        string seleccion = Convert.ToString(aux1);
                        resultado = a.crearJugador(nombre, apellido, edad, fecha, rol, altura, peso, pais, "NO", seleccion, tipo);
                        limpiar();
                    } 
                }
            }
            if(resultado == "ok")
            {
                MessageBox.Show("Jugador creado/a correctamente");
            } else
            {
                MessageBox.Show("Error, " + resultado);
            }
        }

        private void limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            cbxRol.Text = "";
            txtAltura.Text = "";
            txtPeso.Text = "";
            txtPais.Text = "";
        }

        private void crearJugador_Load(object sender, EventArgs e)
        {
            dtpFecha.MaxDate = DateTime.Today.AddYears(-17);
            dtpFecha.MinDate = DateTime.Today.AddYears(-100);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                checkBox2.Enabled = false; 
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                btnCrear.Enabled = true;
            } else
            {
                checkBox2.Enabled = true;
                checkBox4.Enabled = true;
                checkBox3.Enabled = true;
                btnCrear.Enabled = false;
            }
        }

        private void checkbox2Cambio()
        {
            object aux = cbxRol.SelectedItem;
            string rol = Convert.ToString(aux);
            label14.Text = rol;
            DataTable ligas = new DataTable();
            AfyConsultaSQL a = new AfyConsultaSQL();
            ligas = a.ligasDisponibles(ligas, rol);
            cbxLigas.DataSource = ligas;
            cbxLigas.ValueMember = "nombreLiga";
            cbxLigas.DisplayMember = "nombreLiga";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkbox2Cambio();
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                cbxLigas.Text = "";
                cbxEquipos.Text = "";
                btnCrear.Enabled = false;
            }
        }

        private void checkbox3()
        {
            object aux = cbxRol.SelectedItem;
            string deporte = Convert.ToString(aux);
            label18.Text = deporte;
            DataTable paises = new DataTable();
            AfyConsultaSQL a = new AfyConsultaSQL();
            paises = a.seleccionesConDisciplinas(deporte, paises);
            cbxSelecciones.DataSource = paises;
            cbxSelecciones.ValueMember = "nombre";
            cbxSelecciones.DisplayMember = "nombre";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox1.Enabled = false;
                checkBox4.Enabled = false;
                checkbox3();
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox1.Enabled = true;
                checkBox4.Enabled = true;
                cbxSelecciones.Text = "";
                btnCrear.Enabled = false;
            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = true;
                btnCrear4.Visible = true;
            }
            else
            {
                btnCrear4.Visible = false;
                checkBox3.Enabled = true;
                checkBox2.Enabled = true;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox1.Enabled = true;
                checkBox4.Enabled = false;
            }
        }

        private void cbxLigasCambio()
        {
            object aux = cbxLigas.SelectedValue;
            string liga = Convert.ToString(aux);
            AfyConsultaSQL a = new AfyConsultaSQL();
            DataTable equipos = new DataTable();
            equipos = a.equiposDeLigas(liga, equipos);
            cbxEquipos.DataSource = equipos;
            cbxEquipos.ValueMember = "nombre";
            cbxEquipos.DisplayMember = "nombre";
        }

        private void cbxLigas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbxLigasCambio();           
        }

        private void cbxEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCrear.Enabled = true;
        }

        private void cbxSelecciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCrear.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string fecha = dtpFecha.Value.ToShortDateString();
            string nombre = txtNombre.Text, apellido = txtApellido.Text;
            string auxx = txtEdad.Text;
            string edad = txtEdad.Text;
            object aux = cbxRol.SelectedItem;
            string rol = Convert.ToString(aux);
            string altura = txtAltura.Text, pais = txtPais.Text;
            string peso = txtPeso.Text;
            AfyConsultaSQL a = new AfyConsultaSQL();
            string resultado = "";
            int tipo = 0;
            object aux1 = cbxSelecciones.SelectedValue;
            string nombreSeleccion = Convert.ToString(aux1);
            object aux2 = cbxEquipos.SelectedValue;
            string nombreCuadro = Convert.ToString(aux2);
            tipo = 4;
            resultado = a.crearJugador(nombre, apellido, edad, fecha, rol, altura, peso, pais, nombreCuadro, nombreSeleccion, tipo);
            if (resultado == "ok")
            {
                MessageBox.Show("Jugador/a creado correctamente");
            }
            else
            {
                MessageBox.Show("Error: " + resultado);
            }
        }
        private void cbxSelecciones_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }
    }
}
