using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Afy
{
    class AfySQL
    {
        public int registrar(AfyUsuario usuario)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sentencia = "insert into Usuario(Email, Nickname, Contrasenia, Tipo) values (@Email, @Nickname, @Contrasenia, @Tipo)";

            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            cmd.Parameters.AddWithValue("@Email", usuario.Email);
            cmd.Parameters.AddWithValue("@Nickname", usuario.Usuario);
            cmd.Parameters.AddWithValue("@Contrasenia", usuario.Contrasenia);
            cmd.Parameters.AddWithValue("@Tipo", usuario.Tipo);
            int insertar = cmd.ExecuteNonQuery();

            return insertar;
        }
        
        public bool usuarioExiste(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();

            string sentencia = "SELECT Email FROM Usuario WHERE Nickname= '"+usuario+"'";

            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            reader = cmd.ExecuteReader();

            if (reader.HasRows) //Comprobar si hay columnas, osea que ya existe el usuario.
            {
                return true;
            } else
            {
                return false;
            }
        }
        
        public AfyUsuario login(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();

            string sentencia = "SELECT Email, Nickname, Contrasenia, Tipo FROM Usuario WHERE Nickname = '"+usuario+"'";

            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            cmd.Parameters.AddWithValue("@Nickname", usuario);
            reader = cmd.ExecuteReader();

            AfyUsuario usuarios = null;

            while (reader.Read())
            {
                usuarios = new AfyUsuario();
                usuarios.Email = reader["Email"].ToString();
                usuarios.Usuario = reader["Nickname"].ToString();
                usuarios.Contrasenia = reader["Contrasenia"].ToString();
                usuarios.Tipo = reader["Tipo"].ToString();               
            }
            return usuarios;
        }


    }
}
