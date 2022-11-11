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
    public partial class consultarEquipos : Form
    {
        public consultarEquipos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione algo");
            } else
            {
                if (comboBox1.SelectedIndex == 1 && cbxFiltrar.SelectedIndex == 0) //Mostrar selecciones por deportes
                {
                    object aux = cbxDeportes.SelectedValue;
                    string deportes = Convert.ToString(aux);
                    DataTable mostrar = new DataTable();
                    AfyConsultaSQL afy = new AfyConsultaSQL();
                    mostrar = afy.datosPaisesYDeportes(mostrar, deportes);
                    dataGridView2.DataSource = mostrar;
                } else
                {
                    if(comboBox1.SelectedIndex == 1 && cbxFiltrar.SelectedIndex == 1)
                    {
                        object aux = cbxPaises.SelectedValue;
                        string pais = Convert.ToString(aux);
                        DataTable mostrar = new DataTable();
                        AfyConsultaSQL afy = new AfyConsultaSQL();
                        mostrar = afy.datosPaises(mostrar, pais);
                        dataGridView2.DataSource = mostrar;
                    } else
                    {
                        if (comboBox1.SelectedIndex == 2)
                        {
                            object aux2 = cbxDeportesCuadros.SelectedValue;
                            string disciplina = Convert.ToString(aux2);
                            object aux1 = cmbLigas.SelectedValue;
                            string liga = Convert.ToString(aux1);
                            DataTable mostrartabla = new DataTable();
                            AfyConsultaSQL afy = new AfyConsultaSQL();
                            mostrartabla = afy.mostrarCuadros(mostrartabla, disciplina, liga);
                            dataGridView2.DataSource = mostrartabla;
                        }
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 1)
            {
                lblMostrar.Text = "Filtrar por...";
                cbxFiltrar.Visible = true;
                cbxDeportesCuadros.Visible = false;
                cmbLigas.Visible = false;
            } else
            {
                if (comboBox1.SelectedIndex == 2)
                {
                    cbxDeportesCuadros.Visible = true;
                    cbxFiltrar.Visible = false;
                    cbxDeportes.Visible = false;
                    cbxPaises.Visible = false;
                    cmbLigas.Visible = true;
                    label3.Text = "Deportes disponibles...";
                    DataTable ligas = new DataTable();
                    AfyConsultaSQL a = new AfyConsultaSQL();
                    ligas = a.deportesConDatos(ligas, 1);
                    cbxDeportesCuadros.DataSource = ligas;
                    cbxDeportesCuadros.ValueMember = "disciplina";
                    cbxDeportesCuadros.DisplayMember = "disciplina";
                }
            }
        }

        private void cbxSelecciones_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void cbxSelecciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxFiltrar.SelectedIndex == 0)
            {
                cbxDeportes.Visible = true;
                cbxPaises.Visible = false;
                label3.Text = "Deportes disponibles...";
                DataTable deportes = new DataTable();
                AfyConsultaSQL a = new AfyConsultaSQL();
                deportes = a.deportesConDatos(deportes, 2);
                cbxDeportes.DataSource = deportes;
                cbxDeportes.ValueMember = "disciplina";
                cbxDeportes.DisplayMember = "disciplina";
            } else
            {
                if(cbxFiltrar.SelectedIndex == 1)
                {
                    cbxDeportes.Visible = false;
                    cbxPaises.Visible = true;
                    lblMostrar.Text = "Países dispoibles...";
                    DataTable paises = new DataTable();
                    AfyConsultaSQL a = new AfyConsultaSQL();
                    paises = a.mostrarPaises(paises);
                    cbxPaises.DataSource = paises;
                    cbxPaises.ValueMember = "nombre";
                    cbxPaises.DisplayMember = "nombre";
                } 
            }
        }
        private void cbxPaises_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }
        private void cbxPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cbxCuadros_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cbxDeportesCuadros_SelectionChangeCommitted(object sender, EventArgs e)
        {
            object aux = cbxDeportesCuadros.SelectedValue;
            string deporte = Convert.ToString(aux);
            DataTable ligas = new DataTable();
            AfyConsultaSQL a = new AfyConsultaSQL();
            ligas = a.ligasDisponibles(ligas, deporte);           
            if(ligas.Rows.Count > 0)
            {
                cmbLigas.DataSource = ligas;
                cmbLigas.ValueMember = "nombreLiga";
                cmbLigas.DisplayMember = "nombreLiga";
            } else
            {
                cmbLigas.DataSource = null;
                cmbLigas.Items.Clear();
                cmbLigas.Text = "(Sin datos)";
            }
        }

    }
}
