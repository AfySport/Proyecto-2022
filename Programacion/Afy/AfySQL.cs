using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
            string sentencia = "insert into Usuario(Email, Nickname, Contrasenia, Tipo, fechaRegistro) values (@Email, @Nickname, @Contrasenia, @Tipo, @fechaRegistro)";
            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            cmd.Parameters.AddWithValue("@Email", usuario.Email);
            cmd.Parameters.AddWithValue("@Nickname", usuario.Usuario);
            cmd.Parameters.AddWithValue("@Contrasenia", usuario.Contrasenia);
            cmd.Parameters.AddWithValue("@Tipo", usuario.Tipo);
            cmd.Parameters.AddWithValue("@fechaRegistro", usuario.FechaRegistro);
            int insertar = cmd.ExecuteNonQuery();

            return insertar;
        } //Registra usuario en la tabla
        
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
        } //Comprueba si el usuario existe

        public int mailSuscriptoExiste(string Email)
        {
            int devolver = 0;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();

            string sentencia = "SELECT EmailSuscripto FROM suscripto WHERE EmailSuscripto= '" + Email + "'";

            MySqlCommand cmd = new MySqlCommand(sentencia, cone);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                devolver = 1;
            }

            return devolver;
        } //Comprueba si el mail existe

        public bool mailExiste(string Email)
        {
            MySqlDataReader reader;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();

            string sentencia = "SELECT Email FROM Usuario WHERE Email= '" + Email + "'";

            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            reader = cmd.ExecuteReader();

            if (reader.HasRows) //Comprobar si hay columnas, osea si existe un mail.
            {
                return true;
            }
            else
            {
                return false;
            }
        } //Comprueba si el mail existe
        
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

            while (reader.Read()) //Asignacion de valores
            {
                usuarios = new AfyUsuario();
                usuarios.Email = reader["Email"].ToString();
                usuarios.Usuario = reader["Nickname"].ToString();
                usuarios.Contrasenia = reader["Contrasenia"].ToString();
                usuarios.Tipo = reader["Tipo"].ToString();               
            }
            return usuarios;
        } //Datos de usuario con login

        public bool agregarMailSuscriptor(string email)
        {
            MySqlDataReader reader;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();

            string sentencia = "INSERT INTO suscripto(EmailSuscripto) VALUES ('" + email + "')";
            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                return true;//Creado
            }
            else
            {
                return false;
            }
        } //Agrega mail a tabla suscripto

        public int agregarTarjeta(string email, string tipoTarjeta, string numeroTarjeta, string fechaVencTarjeta)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sentencia = "INSERT INTO tarjetacredito(NumeroTarjeta, Vencimiento, Tipo, EmailSuscripto) VALUES (@NumeroTarjeta, @Vencimiento, @Tipo, @EmailSuscripto)";
            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            cmd.Parameters.AddWithValue("@NumeroTarjeta", numeroTarjeta);
            cmd.Parameters.AddWithValue("@Vencimiento", fechaVencTarjeta);
            cmd.Parameters.AddWithValue("@Tipo", tipoTarjeta);
            cmd.Parameters.AddWithValue("@EmailSuscripto", email);
            int insertar = cmd.ExecuteNonQuery(); 
            return insertar;
        } //Agrega tarjeta a tabla

        public int suscripcionDatos(string numeroTarjeta, string Email)
        {
            DateTime fechaHoy = DateTime.Today;
            DateTime fechaVe = DateTime.Today.AddMonths(1);
            string formato = "yyyy-MM-dd";
            string fechaHy = (fechaHoy.ToString(formato));
            string fechaVcmto = (fechaVe.ToString(formato));

            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sentencia = "INSERT INTO suscripcion(FechaInicio, FechaFin, NumeroTarjeta, EmailSuscripto) VALUES (@FechaInicio, @FechaFin, @NumeroTarjeta, @EmailSuscripto)";
            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            cmd.Parameters.AddWithValue("@FechaInicio", fechaHy);
            cmd.Parameters.AddWithValue("@FechaFin", fechaVcmto);
            cmd.Parameters.AddWithValue("@NumeroTarjeta", numeroTarjeta);
            cmd.Parameters.AddWithValue("@EmailSuscripto", Email);
            int insertar = cmd.ExecuteNonQuery();
            return insertar;           
        } //Datos de la suscripción

        public bool actualizarSuscriptor(string email)
        {
            MySqlDataReader reader;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sentencia1 = "UPDATE Usuario SET Tipo='U-Suscrito' where EMAIL='"+email+"'";        
            MySqlCommand cmd = new MySqlCommand(sentencia1, cone);
            reader = cmd.ExecuteReader();
            
            if (reader.HasRows) 
            {
                return true;//Creado
            } else
            {
                return false;
            }
           
        } //Actualiza estado de suscripción a usuario

        public int utiliza(string emailSuscripto, string numeroTarjeta)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();

            string sentencia = "INSERT INTO utiliza(EmailSuscripto, NumeroTarjeta) VALUES (@EmailSuscripto, @NumeroTarjeta)";
            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            cmd.Parameters.AddWithValue("@EmailSuscripto", emailSuscripto);
            cmd.Parameters.AddWithValue("@NumeroTarjeta", numeroTarjeta);
            int insertar = cmd.ExecuteNonQuery();

            return insertar;
        } //Relacion entre email y numero

        public string MostrarUsuarios(string usuariosMostrar)
        {
            string devolver = "";
            afyAdminConsulta afyc = new afyAdminConsulta();
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            MySqlCommand cmd;
            MySqlDataReader reader;
            try
            {
                if (usuariosMostrar == "U-Suscrito")
                {

                    string sql = "SELECT * FROM Usuario WHERE Tipo = '"+usuariosMostrar+"'";
                    cmd = new MySqlCommand(sql, cone);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        devolver = "mostrarSuscritos";
                    }
                }
                else
                {
                    if (usuariosMostrar == "U-NoSuscrito")
                    {
                        string sql = "SELECT * FROM Usuario WHERE Tipo = '"+usuariosMostrar+"'";
                        cmd = new MySqlCommand(sql, cone);
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            devolver = "mostrarNoSuscritos";
                        }
                    }
                    else
                    {
                        if (usuariosMostrar == "Admin")
                        {
                            string sql = "SELECT * FROM Usuario WHERE Tipo = '"+usuariosMostrar+"'";
                            cmd = new MySqlCommand(sql, cone);
                            reader = cmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                devolver = "mostrarAdmins";
                            }
                        }
                        else
                        {
                            string sql = "SELECT * FROM Usuario";
                            cmd = new MySqlCommand(sql, cone);
                            reader = cmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                devolver = "mostrarTodo";
                            }
                        }
                    }
                }
            }catch(Exception ex)
            {
                devolver = "error";
            }
            return devolver;
        }   //Devuelve que debo mostar

        public int eliminarUsuarioSuscripto(string email, string usuario)
        {
            int devolver = 0;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sql = "delete from suscripcion where EmailSuscripto='" + email + "'";
            MySqlCommand cmd = new MySqlCommand(sql, cone);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                devolver = 1;
            }
            return devolver;
        }  //Elimina al usuario suscripto de la tabla "suscripcion"

        public int eliminarSuscriptorTablaUtiliza(string email)
        {
            int devolver = 0;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sql = "delete from utiliza where EmailSuscripto='" + email + "'";
            MySqlCommand cmd = new MySqlCommand(sql, cone);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                devolver = 1;
            }
            return devolver;
        } //Elimina al usuario suscripto de la tabla "utiliza"

        public int eliminarSuscriptorTablaTarjetacredito(string email)
        {
            int devolver = 0;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sql = "delete from tarjetacredito where EmailSuscripto='" + email + "'";
            MySqlCommand cmd = new MySqlCommand(sql, cone);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                devolver = 1;
            }
            return devolver;
        } //Elimina al usuario suscripto de la tabla "tarjetacredito"

        public int eliminarSuscriptorTablaSuscripto(string email)
        {
            int devolver = 0;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sql = "delete from suscripto where EmailSuscripto='" + email + "'";
            MySqlCommand cmd = new MySqlCommand(sql, cone);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                devolver = 1;
            }
            return devolver;
        } //Elimina al usuario suscripto de la tabla "suscripto"

        public int EliminarUsuario(string email, string usuario) //Elimina al usuario
        {
            int devolver = 0;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sql = "delete from usuario where Email='"+email+"' and Nickname = '"+usuario+"'";
            MySqlCommand cmd = new MySqlCommand(sql, cone);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                devolver = 1;
            }
            return devolver;
        }

        public int crearNuevoAdmin(string email, string usuario)
        {
            int devolver = 0;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sql = "update Usuario set Tipo='Admin' where Email='"+email+"' and Nickname='"+usuario+"'";
            MySqlCommand cmd = new MySqlCommand(sql, cone);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                devolver = 1;//Checkeado
            }
            return devolver;
        } //Crea nuevo administrador

        public int sacarPermisoAdmin(string email, string usuario)
        {
            int devolver = 0;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sql = "update Usuario set Tipo='U-NoSuscrito' where Email='" + email + "' and Nickname='" + usuario + "'";
            MySqlCommand cmd = new MySqlCommand(sql, cone);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                devolver = 1;//Checkeado
            }
            return devolver;
        } //Crea nuevo administrador

        public string enviarMailRecuperacion(string email)
        {
            string devolver = "";
            MySqlDataReader reader;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string usuario, contrasenia;
            string sentencia = "SELECT Nickname, Contrasenia FROM usuario WHERE Email = '" + email + "'";

            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            cmd.Parameters.AddWithValue("@Email", email);
            reader = cmd.ExecuteReader();

            while (reader.Read()) //Asignacion de valores
            {
                usuario = reader["Nickname"].ToString();
                contrasenia = reader["Contrasenia"].ToString();
                AfyEnvioMail afymail = new AfyEnvioMail();
                afymail.enviarMailrecuperacion(email, usuario, contrasenia);
            }
            return devolver;
        } //Envio mail con datos

        public string agregarPublicidad(int id, string nombre, byte[] imagen)
        {
            string devolver = "";
            id += 1;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sql = "INSERT INTO publicidad(idpublicidad, nombrePublicidad, imagen) values (@idpublicidad, @nombrePublicidad, @imagen)";
                MySqlCommand cmd = new MySqlCommand(sql, cone);
                cmd.Parameters.AddWithValue("@idpublicidad", id);
                cmd.Parameters.AddWithValue("@nombrePublicidad", nombre);
                cmd.Parameters.AddWithValue("@imagen", imagen);
                cmd.ExecuteNonQuery();
                devolver = "ok";
            }
            catch(MySqlException ex)
            {
                devolver = ex.ToString();
            }
            return devolver;
        } //Agrego imagen

        public int contarImagenesPublicidad()
        {
            int resultado = 0;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();

            try
            {
                string sql = "select count(*) from publicidad";
                MySqlCommand cmd = new MySqlCommand(sql, cone);
                cmd.ExecuteNonQuery();
                int cantColumnas = int.Parse(cmd.ExecuteScalar().ToString());
                return cantColumnas;
            }
            catch (MySqlException ex)
            {

            } 
            return resultado;
        } //Cantidad de publicidad en el momento.

        public MemoryStream mostrarImagen(int id)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sql = "SELECT imagen FROM publicidad WHERE idpublicidad = " + id;
                MySqlCommand cmd = new MySqlCommand(sql, cone);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    MemoryStream memoria = new MemoryStream((byte[])reader["imagen"]);
                    return memoria;
                }
            }
            catch(MySqlException ex)
            {

            }
            finally
            {
                cone.Close();
            }
            return null;
        }   //Devuelve la imagen a mostrar

        public string nombrePublicidad(int id)
        {
            string devolver = "";
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sql = "SELECT nombrePublicidad FROM publicidad WHERE idpublicidad = " + id;
                MySqlCommand cmd = new MySqlCommand(sql, cone);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    devolver = reader["nombrePublicidad"].ToString();
                }
            }
            catch (MySqlException ex)
            {
                devolver = ex.ToString();
            }
            return devolver;
        }    //Devuelve el nombre de la publicidad

        public bool eliminarPublicidad(int id)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sql = "delete from publicidad where idpublicidad='"+id+"'";
            MySqlCommand cmd = new MySqlCommand(sql, cone);
            MySqlDataReader reader = cmd.ExecuteReader();
            actualizarIdPublicidad(id);
            if (reader.Read())
            {               
                return true;
            } else
            {
                return false;
            }
        } //Elimina la publicidad

        public bool actualizarIdPublicidad(int idEliminar)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            int maximo = contarImagenesPublicidad();
            MySqlCommand cmd;
            int contAux = idEliminar;
            int idViejo = idEliminar + 1;
            for (int x = idEliminar; x<=maximo; x++)
            {
                string sql = "UPDATE publicidad set idpublicidad='"+contAux+"' where idpublicidad='"+idViejo+"'";
                cmd = new MySqlCommand(sql, cone);
                cmd.ExecuteNonQuery();
                idViejo += 1;
                contAux += 1;
            }
            return true;
        }  //Se actualizan los id
    }
}
