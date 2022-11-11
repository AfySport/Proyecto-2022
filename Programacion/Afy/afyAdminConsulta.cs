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
using MySql.Data;
namespace Afy
{
    public partial class afyAdminConsulta : Form
    {

        public afyAdminConsulta()
        {
            InitializeComponent();
        }    

        private void btnSalir_Click(object sender, EventArgs e)
        {
            AfyAdmin afya = new AfyAdmin();
            this.Hide();                                         
            afya.Show();
        }

        private void afyAdminConsulta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            AfyConsultaSQL afysql = new AfyConsultaSQL();
            object valor = combob1.SelectedItem;
            string resultado = "";
            string mostrar = Convert.ToString(valor);
            resultado = afysql.mostrarUsuarios(mostrar);
            try
            {

                DataTable origen;
                MySqlConnection cone = AfyConexion.conexion();
                cone.Open();
                MySqlCommand cmd;
                MySqlDataAdapter adapter;
               
                if (resultado == "mostrarSuscritos")
                {
                    string sql = "select * from Usuario where Tipo='U-Suscrito'";
                    cmd = new MySqlCommand(sql, cone);
                    adapter = new MySqlDataAdapter(cmd);
                    origen = new DataTable();
                    adapter.Fill(origen);
                    dataGridView1.DataSource = origen;
                } else
                {
                    if (resultado == "mostrarNoSuscritos")
                    {
                        string sql = "select * from Usuario where Tipo='U-NoSuscrito'";
                        cmd = new MySqlCommand(sql, cone);
                        adapter = new MySqlDataAdapter(cmd);
                        origen = new DataTable();
                        adapter.Fill(origen);
                        dataGridView1.DataSource = origen;
                    } else
                    {
                        if(resultado == "mostrarAdmins")
                        {
                            string sql = "select * from Usuario where Tipo='Admin'";
                            cmd = new MySqlCommand(sql, cone);
                            adapter = new MySqlDataAdapter(cmd);
                            origen = new DataTable();
                            adapter.Fill(origen);
                            dataGridView1.DataSource = origen;
                        } else
                        {
                            if(resultado == "mostrarTodo")
                            {
                                string sql = "select * from Usuario";
                                cmd = new MySqlCommand(sql, cone);
                                adapter = new MySqlDataAdapter(cmd);
                                origen = new DataTable();
                                adapter.Fill(origen);
                                dataGridView1.DataSource = origen;
                            } 
                        }
                    }
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void mostrar()
        {
            txtEmail.Visible = true; 
            label3.Visible = true;
            label4.Visible = true;
            txtUsuario.Visible = true;
            txtCodigoSeguridad.Visible = true;
            label6.Visible = true;
        }

        private void ocultar()
        {
            label3.Visible = false; 
            label4.Visible = false; 
            txtUsuario.Visible = false; 
            txtEmail.Visible = false; 
            txtCodigoSeguridad.Visible = false; 
            label6.Visible = false;
        }

        private void cbx1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbx1.Checked == true)
            {
                mostrar();
                cb3.Enabled = false;
                cbx2.Enabled = false;
                lblEliminarUsuarios.Visible = true;
                btnEliminar.Visible = true;               
            } else
            {
                ocultar();
                cbx2.Enabled = true;
                cb3.Enabled = true;
                lblEliminarUsuarios.Visible = false;
                btnEliminar.Visible = false;
            }
        }

        private void cbx2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx2.Checked == true)
            {
                mostrar();
                cbx1.Enabled = false;
                cb3.Enabled = false;
                label5.Visible = true;
                btnCrearAdmin.Visible = true;
            }
            else
            {
                ocultar();
                cbx1.Enabled = true;
                cb3.Enabled = true;
                label5.Visible = false;
                btnCrearAdmin.Visible = false;
            }
        }

        private void cb3_CheckedChanged(object sender, EventArgs e)
        {
            if (cb3.Checked == true)
            {
                mostrar();
                cbx1.Enabled = false;
                label7.Visible = true;
                cbx2.Enabled = false;
                btnSacarAdmin.Visible = true;
            }
            else
            {
                ocultar();
                label7.Visible = false;
                btnSacarAdmin.Visible = false;
                cbx1.Enabled = true;
                cbx2.Enabled = true;
            }
        }  
        
        private void button2_Click(object sender, EventArgs e)
        {
            
            string email = txtEmail.Text;
            string usuario = txtUsuario.Text;
            string codigoSeguridad = txtCodigoSeguridad.Text;
            AfyConsultaSQL afys = new AfyConsultaSQL();
            string resultado = afys.eliminarControl(email, usuario, codigoSeguridad);
            if (resultado == "ok")
            {
                MessageBox.Show("Usuario eliminado correctamente");
                limpiar();
            }else
            {
                MessageBox.Show(resultado);
            }
                
        }
        
        private void limpiar()
        {
            txtEmail.Text = "";
            txtCodigoSeguridad.Text = "";
            txtUsuario.Text = "";
        }

        private void btnCrearAdmin_Click(object sender, EventArgs e)
        {           
            string email = txtEmail.Text, usuario = txtUsuario.Text, codigoSeguridad = txtCodigoSeguridad.Text;
            AfyConsultaSQL afy = new AfyConsultaSQL();        
            string resultado = afy.nuevoAdmin(email, usuario, codigoSeguridad);
            if (resultado == "ok")
            {
                MessageBox.Show("Nuevo administrador creado correctamente.");
                limpiar();
            }
            else
            {
                MessageBox.Show(resultado);
            }
                            
        }

        private void btnSacarAdmin_Click(object sender, EventArgs e)
        {
            const string codigoSeguridad = "cccc";
            string email = txtEmail.Text, usuario = txtUsuario.Text;
            AfyConsultaSQL afy = new AfyConsultaSQL();
            if (string.IsNullOrEmpty(txtCodigoSeguridad.Text))
            {
                MessageBox.Show("Ingrese el código de seguridad");
            }
            else
            {
                if (codigoSeguridad != txtCodigoSeguridad.Text)
                {
                    MessageBox.Show("El código es erroneo");
                }
                else
                {
                    string resultado = afy.sacarAdmin(email, usuario);
                    if (resultado == "ok")
                    {
                        MessageBox.Show("Nuevo administrador removido exitosamente.");
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show(resultado);
                    }
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AfyConsultaSQL a = new AfyConsultaSQL();
            a.crearRegistroUsuarios();
            MessageBox.Show("Registro pdf creado correctamente");
        }
    }
}
