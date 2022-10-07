using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Afy
{
    public partial class AfyPublicidad : Form
    {
        public AfyPublicidad()
        {
            InitializeComponent();
            AfyConsultaSQL afy = new AfyConsultaSQL();
            int numero = afy.cantidadImagenes();
            txtCantImagenes.Text = Convert.ToString(numero);
            maximoImagenes = numero;
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Publicidad (Solo PNG) |*.png";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pb1.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MemoryStream memoria = new MemoryStream();
            pb1.Image.Save(memoria, ImageFormat.Png);
            byte[] imagen = memoria.ToArray();
            AfyConsultaSQL afy = new AfyConsultaSQL();
            string respuesta = afy.agregarPublicidad(txtNombrePublicidad.Text, imagen);
            if(respuesta == "ok")
            {
                MessageBox.Show("Imagen añadida correctamente");
                txtNombrePublicidad.Text = "";
                pb1.Image = null; //Limpio
            } else
            {
                MessageBox.Show(respuesta);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }       

        private void AfyPublicidad_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AfyPublicidad_Load(object sender, EventArgs e)
        {
            
        }
        int maximoImagenes;
        private void button1_Click(object sender, EventArgs e)
        {
            AfyConsultaSQL afy = new AfyConsultaSQL();
            int numero = afy.cantidadImagenes();
            maximoImagenes = numero;
            txtCantImagenes.Text = Convert.ToString(numero);
        }
        int idPublicidad = 0;
        
        private void button2_Click(object sender, EventArgs e)
        {
            idPublicidad = idPublicidad - 1;
            txtIdImagen.Text = Convert.ToString(idPublicidad);
            if(idPublicidad < 1)
            {
                MessageBox.Show("Por favor, la publicidad está asignada a numeros mayores o iguales a 1");
                txtIdImagen.Text = Convert.ToString(1);
                idPublicidad = 1;
            } else
            {
                AfyConsultaSQL afy = new AfyConsultaSQL();
                MemoryStream imagen = afy.mostrarImagen(idPublicidad);
                txtNombrePubli.Text = afy.nombrePublicidad(idPublicidad);
                Bitmap bitmap = new Bitmap(imagen);
                pb1.Image = bitmap;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {                       
            idPublicidad += 1;
            txtIdImagen.Text = Convert.ToString(idPublicidad);
            if (idPublicidad > maximoImagenes)
            {
                txtIdImagen.Text = Convert.ToString(maximoImagenes);
                idPublicidad = maximoImagenes;
                MessageBox.Show("No hay mas imágenes.");
            } else
            {
                AfyConsultaSQL afy = new AfyConsultaSQL();
                MemoryStream imagen = afy.mostrarImagen(idPublicidad);
                txtNombrePubli.Text = afy.nombrePublicidad(idPublicidad);
                Bitmap bitmap = new Bitmap(imagen);
                pb1.Image = bitmap;
            }
        }

        private void radioButton2_Leave(object sender, EventArgs e)
        {
            lblCantidadImagenes.Visible = false;
            txtCantImagenes.Visible = false;
            btnActualizar.Visible = false;
            btnSiguiente.Visible = false;
            btnAnterior.Visible = false;
            pb1.Visible = false;
            pb1.Image = null;
            label2.Visible = false;
            label3.Visible = false;
            txtIdImagen.Visible = false;
            txtNombrePubli.Visible = false;
            idPublicidad = 0;
            txtNombrePubli.Text = "";
            txtIdImagen.Text = "";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true)
            {
                lblCantidadImagenes.Visible = true;
                txtCantImagenes.Visible = true;
                btnActualizar.Visible = true;
                btnSiguiente.Visible = true;
                btnAnterior.Visible = true;
                pb1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                txtIdImagen.Visible = true;
                txtNombrePubli.Visible = true;
                txtEliminarPublicidad.Visible = true;
                lblEliminarPublicidad.Visible = true;
                lblIdImagenEliminar.Visible = true;
                btnEliminarPublicidad.Visible = true;
            } else
            {
                lblCantidadImagenes.Visible = false;
                txtCantImagenes.Visible = false;
                btnActualizar.Visible = false;
                btnSiguiente.Visible = false;
                btnAnterior.Visible = false;
                txtEliminarPublicidad.Visible = false;
                pb1.Visible = false;
                pb1.Image = null;
                label2.Visible = false;
                label3.Visible = false;
                txtIdImagen.Visible = false;
                txtNombrePubli.Visible = false;
                lblEliminarPublicidad.Visible = false;
                lblIdImagenEliminar.Visible = false;
                btnEliminarPublicidad.Visible = false;
                idPublicidad = 0;
                txtNombrePubli.Text = "";
                txtIdImagen.Text = "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                pb1.Visible = true;
                lblMostrar.Visible = true;
                btnAgregar.Visible = true;
                btnExaminar.Visible = true;
                lblMostrar.Visible = true;
                lblNombrePublicidad.Visible = true;
                txtNombrePublicidad.Visible = true;
                checkBox2.Enabled = false;
            } else
            {
                checkBox2.Enabled = true;
                pb1.Visible = false;
                btnAgregar.Visible = false;
                btnExaminar.Visible = false;
                lblMostrar.Visible = false;
                lblNombrePublicidad.Visible = false;
                txtNombrePublicidad.Visible = false;
            }
        }

        private void btnEliminarPublicidad_Click(object sender, EventArgs e)
        {
            AfyConsultaSQL afy = new AfyConsultaSQL();
            string resultado = afy.eliminarPublicidad(int.Parse(txtEliminarPublicidad.Text));
            if(resultado == "ok")
            {
                MessageBox.Show("Su imagen se eliminó correctamente. Salga y entre de nuevo para actualizar.");
                AfyAdmin a = new AfyAdmin();
                this.Hide();
                a.Show();
            } else
            {
                MessageBox.Show(resultado);
            }
        }
    }
}
