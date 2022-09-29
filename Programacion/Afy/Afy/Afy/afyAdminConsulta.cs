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



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (chbSuscritos.Checked == true)
            {
                chbNoSuscritos.Enabled = false;
                chbAdmin.Enabled = false;
                chbUsuarios.Enabled = false;
                try
                {
                    MySqlConnection cone = AfyConexion.conexion();
                    cone.Open();
                    DataTable origen;
                    string sql = "select * from Usuario where Tipo='U-Suscrito'";
                    MySqlCommand mycmd = new MySqlCommand(string.Format(sql), cone);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(mycmd);
                    origen = new DataTable();
                    adapter.Fill(origen);
                    dataGridView1.DataSource = origen;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                }
            } else
            {
                chbNoSuscritos.Enabled = true;
                chbAdmin.Enabled = true;
                chbUsuarios.Enabled = true;
                DataTable dt = (DataTable)dataGridView1.DataSource;
                dt.Clear();
            }
        }

        private void chbNoSuscritos_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNoSuscritos.Checked == true)
            {
                chbSuscritos.Enabled = false;
                chbAdmin.Enabled = false;
                chbUsuarios.Enabled = false;
                try
                {
                    MySqlConnection cone = AfyConexion.conexion();
                    cone.Open();
                    DataTable origen;
                    string sql = "select * from Usuario where Tipo='U-NoSuscrito'";
                    MySqlCommand mycmd = new MySqlCommand(string.Format(sql), cone);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(mycmd);
                    origen = new DataTable();
                    adapter.Fill(origen);
                    dataGridView1.DataSource = origen;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                }
            }
            else
            {
                chbSuscritos.Enabled = true;
                chbAdmin.Enabled = true;
                chbUsuarios.Enabled = true;
                DataTable dt = (DataTable)dataGridView1.DataSource;
                dt.Clear();
            }
        }

        private void chbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAdmin.Checked == true)
            {
                chbSuscritos.Enabled = false;
                chbNoSuscritos.Enabled = false;
                chbUsuarios.Enabled = false;
                try
                {
                    MySqlConnection cone = AfyConexion.conexion();
                    cone.Open();
                    DataTable origen;
                    string sql = "select * from Usuario where Tipo='Admin'";
                    MySqlCommand mycmd = new MySqlCommand(string.Format(sql), cone);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(mycmd);
                    origen = new DataTable();
                    adapter.Fill(origen);
                    dataGridView1.DataSource = origen;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                }
            }
            else
            {
                chbSuscritos.Enabled = true;
                chbNoSuscritos.Enabled = true;
                chbUsuarios.Enabled = true;
                DataTable dt = (DataTable)dataGridView1.DataSource;
                dt.Clear();
            }
        }

        private void chbUsuarios_CheckedChanged(object sender, EventArgs e)
        {
            if (chbUsuarios.Checked == true)
            {
                chbSuscritos.Enabled = false;
                chbAdmin.Enabled = false;
                chbNoSuscritos.Enabled = false;
                try
                {
                    MySqlConnection cone = AfyConexion.conexion();
                    cone.Open();
                    DataTable origen;
                    string sql = "select * from Usuario";
                    MySqlCommand mycmd = new MySqlCommand(string.Format(sql), cone);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(mycmd);
                    origen = new DataTable();
                    adapter.Fill(origen);
                    dataGridView1.DataSource = origen;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                }
            }
            else
            {
                chbSuscritos.Enabled = true;
                chbAdmin.Enabled = true;
                chbNoSuscritos.Enabled = true;
                DataTable dt = (DataTable)dataGridView1.DataSource;
                dt.Clear();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            AfyAdmin afya = new AfyAdmin();
            this.Hide();                                         
            afya.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Email = txtMail.Text;
            string user = txtUsuario.Text;
            string tipoUsuario = "";
            if (txtUsuario.Text == "" || txtMail.Text == "")
            {
                MessageBox.Show("Porfavor llene todos los campos.");
            }
            else
            {
                MySqlConnection cone = AfyConexion.conexion();
                cone.Open();
                try
                {
                    if(rbSuscrito.Checked == true)
                    {
                        tipoUsuario = "U-Suscrito";
                    } else if(rbNoSuscrito.Checked == true)
                    {
                        tipoUsuario = "U-NoSuscrito";
                    } else
                    {
                        tipoUsuario = "Admin";
                    }
                    MySqlCommand mycmd = new MySqlCommand(string.Format("delete from Usuario where email = '" + Email + "' and Nickname = '" + user + "' and Tipo = '" + tipoUsuario + "'"), cone);
                    bool eliminar = Convert.ToBoolean(mycmd.ExecuteNonQuery());
                    if (eliminar == true)
                    {
                        MessageBox.Show("El usuario se eliminó correctamente.");
                        txtMail.Text = "";
                        txtUsuario.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe o las credenciales no coinciden.");
                    }
                }catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                }finally
                {
                    cone.Close();
                }
                
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if(cbx1.Checked == true)
            {
                lblEliminar.Visible = true;
                lblEmailEliminar.Visible = true;
                lblTipoUsuario.Visible = true;
                lblUsuarioEliminar.Visible = true;
                txtMail.Visible = true;
                txtUsuario.Visible = true;
                rbAdmin.Visible = true;
                rbNoSuscrito.Visible = true;
                rbSuscrito.Visible = true;
                btnEliminar.Visible = true;
                cbx2.Enabled = false;
                cb3.Enabled = false;
            } else
            {
                lblEliminar.Visible = false;
                lblEmailEliminar.Visible = false;
                lblTipoUsuario.Visible = false;
                lblUsuarioEliminar.Visible = false;
                txtMail.Visible = false;
                txtUsuario.Visible = false;
                cbx2.Enabled = true;
                rbAdmin.Visible = false;
                rbNoSuscrito.Visible = false;
                rbSuscrito.Visible = false;
                btnEliminar.Visible = false;
                cb3.Enabled = true;
            }
        }

        private void cbx2_CheckedChanged(object sender, EventArgs e)
        {
            if(cbx2.Checked == true)
            {
                lblAdminNuevo.Visible = true;
                txtMail.Visible = true;
                txtUsuario.Visible = true;
                lblEmailEliminar.Visible = true;
                lblUsuarioEliminar.Visible = true;
                btnCrear.Visible = true;
                cbx1.Enabled = false;
                cb3.Enabled = false;
            } else
            {
                lblAdminNuevo.Visible = false;
                txtMail.Visible = false;
                txtUsuario.Visible = false;
                lblEmailEliminar.Visible = false;
                lblUsuarioEliminar.Visible = false;
                btnCrear.Visible = false;
                cbx1.Enabled = true;
                cb3.Enabled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string Email = txtMail.Text;
            string usuario = txtUsuario.Text;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                MySqlCommand mysql = new MySqlCommand(string.Format("update Usuario set Tipo='Admin' where email = '" + Email + "' AND Nickname='" + usuario + "'"), cone);
                bool admin = Convert.ToBoolean(mysql.ExecuteNonQuery());
                if(admin == true)
                {
                    MessageBox.Show("Nuevo Administrador asignado correctamente.");
                    txtMail.Text = "";
                    txtUsuario.Text = "";
                } else
                {
                    MessageBox.Show("No existe el usuario o no coincide.");
                }              
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
            finally
            {
                cone.Close();
            }           
        }

        private void cb3_CheckedChanged(object sender, EventArgs e)
        {
            if (cb3.Checked == true)
            {
                lblAdminNuevo.Visible = false;
                lblSacarAdmin.Visible = true;
                txtMail.Visible = true;
                txtUsuario.Visible = true;
                lblEmailEliminar.Visible = true;
                lblUsuarioEliminar.Visible = true;
                btnCrear.Visible = false;
                btnSacarAdmin.Visible = true;
                cbx1.Enabled = false;
                cbx2.Enabled = false;
            }
            else
            {
                btnSacarAdmin.Visible = false;
                lblAdminNuevo.Visible = false;
                lblSacarAdmin.Visible = false;
                txtMail.Visible = false;
                txtUsuario.Visible = false;
                lblEmailEliminar.Visible = false;
                lblUsuarioEliminar.Visible = false;
                btnCrear.Visible = false;
                cbx1.Enabled = true;
                cbx2.Enabled = true;
            }
        }

        private void btnSacarAdmin_Click(object sender, EventArgs e)
        {
            string Email = txtMail.Text;
            string usuario = txtUsuario.Text;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                MySqlCommand mysql = new MySqlCommand(string.Format("update Usuario set Tipo='U-NoSuscrito' where email = '" + Email + "' AND Nickname='" + usuario + "' and Tipo='Admin'"), cone);
                bool admin = Convert.ToBoolean(mysql.ExecuteNonQuery());
                if (admin == true)
                {
                    MessageBox.Show("Permiso de administrador removido existosamente.");
                    txtMail.Text = "";
                    txtUsuario.Text = "";
                }
                else
                {
                    MessageBox.Show("El usuario no es administrador o no existe.");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
            finally
            {
                cone.Close();
            }
        }

        private void afyAdminConsulta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
