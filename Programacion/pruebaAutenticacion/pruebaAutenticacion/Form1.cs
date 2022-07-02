using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace pruebaAutenticacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario(txtRegistrarUsuario.Text, txtRegistrarConstrasenia.Text);
            lista.Add(u);
            txtRespuestaRegistro.Visible = true;
            txtRegistrarUsuario.Text = "";
            txtRegistrarConstrasenia.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            foreach (Usuario var in lista)
            {
                if (txtLoginContrasenia.Text == "" || txtLoginUsuario.Text == "")
                {
                    MessageBox.Show("Por favor, ingrese nombre y constraseña.");
                }
                else if (txtLoginUsuario.Text.Equals(var.nombre) && !txtLoginContrasenia.Text.Equals(var.contrasenia))
                {
                    MessageBox.Show("Contraseña incorrecta.");
                } else if (txtLoginUsuario.Text.Equals(var.nombre) && txtLoginContrasenia.Text.Equals(var.contrasenia))
                {
                    MessageBox.Show("Bienvenido " + var.nombre + "!");
                    AfySport f2 = new AfySport();
                    f2.Show();
                    this.Hide();
                }
            }
            Usuario admin = new Usuario("admin", "admin");
            lista.Add(admin);
            bool ingresar = false;
            
        }
        ArrayList lista = new ArrayList();
        class Usuario
        {
            public string nombre { set; get; }
            public string contrasenia { set; get; }
            public Usuario()
            {
            }
            public Usuario(string nombre, string contrasenia)
            {
                this.nombre = nombre;
                this.contrasenia = contrasenia;
            }
        }
    }
    
}
