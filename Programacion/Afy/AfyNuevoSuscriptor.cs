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
    public partial class AfyNuevoSuscriptor : Form
    {
        public AfyNuevoSuscriptor()
        {
            InitializeComponent();
            if (Idioma.Tipoidioma == 1)
            {
                idiomaEspaniol();
            }
            else if (Idioma.tipoidioma == 2)
            {
                idiomaIngles();
            }
        }

        private void idiomaEspaniol()
        {
            Idioma.tipoidioma = 1;
            lblAddress.Text = "Dirección";
            lblApellido.Text = "Apellido";
            lblCodigoSeguridad.Text = "CVV";
            lblCorreo.Text = "Email";
            lblDatosUsuario.Text = "Informacion";
            lblFechaVencimiento.Text = "Fecha de vencimiento";
            lblLocalidad.Text = "Ciudad";
            lblMetodoPago.Text = "Método de pago";
            lblNombre.Text = "Nombre";
            lblNuevoSuscriptor.Text = "Suscribirme";
            lblNumeroTarjeta.Text = "Número de tarjeta";
            lblPais.Text = "País";
            lbltelefono.Text = "Teléfono";
            btnAceptar.Text = "Aceptar";
            idiomaToolStripMenuItem.Text = "Idioma";
            españolToolStripMenuItem.Text = "Español";
            inglésToolStripMenuItem.Text = "Ingles";
            button1.Text = "Preguntas frecuentes.";
            lblTextoEspaniol.Visible = true;
            lblTextoInglés.Visible = false;
        }

        private void idiomaIngles()
        {
            Idioma.tipoidioma = 2;
            lblAddress.Text = "Address";
            lblApellido.Text = "Surname";
            lblCodigoSeguridad.Text = "CVV";
            lblCorreo.Text = "Mail";
            lblDatosUsuario.Text = "Information";
            lblFechaVencimiento.Text = "Expiration date";
            lblLocalidad.Text = "City";
            lblMetodoPago.Text = "Card";
            lblNombre.Text = "Name";
            lblNuevoSuscriptor.Text = "Suscribe";
            lblNumeroTarjeta.Text = "Card number";
            lblPais.Text = "Country";
            lbltelefono.Text = "Phone";
            btnAceptar.Text = "Check in";
            idiomaToolStripMenuItem.Text = "Language";
            españolToolStripMenuItem.Text = "Spanish";
            inglésToolStripMenuItem.Text = "English";
            button1.Text = "Frequently asked\n questions";
            lblTextoInglés.Visible = true;
            lblTextoEspaniol.Visible = false;           
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string tarjeta = txtNumeroTarjeta.Text;

            if (comboBox1.SelectedIndex == -1 || string.IsNullOrEmpty(txtNumeroTarjeta.Text) || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1 ||
                string.IsNullOrEmpty(txtCodigoSeguridad.Text) || string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasenia.Text) ||
                string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtLocalidad.Text) ||
                string.IsNullOrEmpty(txtCorreo.Text) || comboBox4.SelectedIndex == -1 || string.IsNullOrEmpty(txtTelefono.Text))
            {
                if (Idioma.Tipoidioma == 1)
                {
                    MessageBox.Show("Complete todos los campos porfavor");
                }
                else if (Idioma.tipoidioma == 2)
                {
                    MessageBox.Show("Complete all the fields.");
                }
            }
            else if (tarjeta.Length < 16 || tarjeta.Length > 16)
            {
                if (Idioma.Tipoidioma == 1)
                {
                    MessageBox.Show("El numero de tarjeta no existe.");
                }
                else
                    MessageBox.Show("Number of card dont exist.");
            } else
            {
                string correo = txtCorreo.Text, user = txtUsuario.Text, contra = txtContrasenia.Text;
                object mes_vencimiento = comboBox2.SelectedItem;
                object anio_vencimiento = comboBox3.SelectedItem;
                object tipo = comboBox1.SelectedItem;
                string tipoTarjeta = Convert.ToString(tipo);
                string fecha_vencimiento_tarjeta = Convert.ToString(mes_vencimiento + "/" + anio_vencimiento);
                string numero_tarjeta = Convert.ToString(txtNumeroTarjeta.Text);
                AfyConsultaSQL afyq = new AfyConsultaSQL();
                string resultado = afyq.controlSuscripcion(correo, user, contra, tipoTarjeta, numero_tarjeta , fecha_vencimiento_tarjeta);

                if(resultado == "ok")
                {
                    if (Idioma.Tipoidioma == 1)
                    {
                        MessageBox.Show("Suscripción realizada con éxito, bienvenido!");
                    }
                    else
                        MessageBox.Show("Successfully made, Welcome!.");
                } else
                {
                    MessageBox.Show("Error " + resultado);
                }
            }          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AfyInformacionSuscribirse afy = new AfyInformacionSuscribirse();
            afy.Show();
            this.Hide();
        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Idioma.Tipoidioma == 2)
            {
                idiomaEspaniol();
                MessageBox.Show("Lenguaje cambiado correctamente.");
            }
            else
            {
                MessageBox.Show("Su idioma ya es el español.");
            }
        }

        private void inglésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Idioma.Tipoidioma == 1)
            {
                idiomaIngles();
                MessageBox.Show("Language changed successfully.");
            }
            else
            {
                MessageBox.Show("Your language is already english.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            AfySport afy = new AfySport();
            afy.Show();
            this.Hide();
        }
    }
}
