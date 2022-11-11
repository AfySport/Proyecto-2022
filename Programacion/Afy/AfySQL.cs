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

            string sentencia = "SELECT Email FROM Usuario WHERE Nickname= '" + usuario + "'";

            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            reader = cmd.ExecuteReader();

            if (reader.HasRows) //Comprobar si hay columnas, osea que ya existe el usuario.
            {
                return true;
            }
            else
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

            string sentencia = "SELECT Email, Nickname, Contrasenia, Tipo FROM Usuario WHERE Nickname = '" + usuario + "'";

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
            string sentencia1 = "UPDATE Usuario SET Tipo='U-Suscrito' where EMAIL='" + email + "'";
            MySqlCommand cmd = new MySqlCommand(sentencia1, cone);
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                return true;//Creado
            }
            else
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

                    string sql = "SELECT * FROM Usuario WHERE Tipo = '" + usuariosMostrar + "'";
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
                        string sql = "SELECT * FROM Usuario WHERE Tipo = '" + usuariosMostrar + "'";
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
                            string sql = "SELECT * FROM Usuario WHERE Tipo = '" + usuariosMostrar + "'";
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
            }
            catch (Exception ex)
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
            string sql = "delete from usuario where Email='" + email + "' and Nickname = '" + usuario + "'";
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
            string sql = "update Usuario set Tipo='Admin' where Email='" + email + "' and Nickname='" + usuario + "'";
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
                //AfyEnvioMail afymail = new AfyEnvioMail();
                //afymail.enviarMailrecuperacion(email, usuario, contrasenia);
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
            catch (MySqlException ex)
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
            catch (MySqlException ex)
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
            string sql = "delete from publicidad where idpublicidad='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(sql, cone);
            MySqlDataReader reader = cmd.ExecuteReader();
            actualizarIdPublicidad(id);
            if (reader.HasRows)
            {
                return true;
            }
            else
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
            for (int x = idEliminar; x <= maximo; x++)
            {
                string sql = "UPDATE publicidad set idpublicidad='" + contAux + "' where idpublicidad='" + idViejo + "'";
                cmd = new MySqlCommand(sql, cone);
                cmd.ExecuteNonQuery();
                idViejo += 1;
                contAux += 1;
            }
            return true;
        }  //Se actualizan los id

        public bool comprobarLigaExiste(string nombre, string deporte, string pais)
        {
            MySqlDataReader reader;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();

            string sentencia = "SELECT nombre FROM liga WHERE nombre= '" + nombre + "' and deporte='" + deporte + "' and pais='" + pais + "'";

            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            reader = cmd.ExecuteReader();

            if (reader.HasRows) //Comprobar si hay columnas, osea que ya existe el usuario.
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int crearLiga(string nombre, string deporte, string pais)
        {
            int devolver = 0;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sentencia = "INSERT INTO liga(nombre, deporte, pais) VALUES (@nombre, @deporte, @pais)";
            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@deporte", deporte);
            cmd.Parameters.AddWithValue("@pais", pais);
            devolver = cmd.ExecuteNonQuery();
            return devolver;
        }

        public DataTable ligas(DataTable tabla, string deporte)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sentencia = "select nombre from liga where deporte = '" + deporte + "'";
                MySqlCommand cmd = new MySqlCommand(sentencia, cone);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(tabla);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return tabla;
        }

        public int crearEquipo(int nuevoId, string disciplina, string nombre, string tipo)
        {
            int devolver = 0;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sentencia = "INSERT INTO equipo(idEquipo, disciplina, nombre, tipo) VALUES (@idEquipo, @disciplina, @nombre, @tipo)";
            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            cmd.Parameters.AddWithValue("@idEquipo", nuevoId);
            cmd.Parameters.AddWithValue("@disciplina", disciplina);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            devolver = cmd.ExecuteNonQuery();
            if(tipo == "Seleccion")
            {
                crearSeleccion(nuevoId, disciplina, nombre);
            }           
            return devolver;
        }

        public bool comprobarSeleccionExiste(string nombre, string disciplina)
        {
            MySqlDataReader reader;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();

            string sentencia = "SELECT nombre FROM seleccion WHERE nombre= '" + nombre + "' and disciplina='" + disciplina + "'";

            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            reader = cmd.ExecuteReader();

            if (reader.HasRows) //Comprobar si hay columnas, osea que la selección existe
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool comprobarCuadroExiste(string disciplina, string nombre, string nombreLiga)
        {
            MySqlDataReader reader;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sentencia = "SELECT nombre FROM cuadro WHERE disciplina= '" + disciplina + "' and nombre='" + nombre + "' and nombreLiga='" + nombreLiga + "'";
            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            reader = cmd.ExecuteReader();
            if (reader.HasRows) //Comprobar si hay columnas, osea que la selección existe
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int devolverIdLiga(string liga)
        {
            int resultado = 0;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sql = "select idLiga from liga where nombre='" + liga + "'";
                MySqlCommand cmd = new MySqlCommand(sql, cone);
                cmd.ExecuteNonQuery();
                int cantEquipos = int.Parse(cmd.ExecuteScalar().ToString());
                return cantEquipos;
            }
            catch (MySqlException ex)
            {

            }
            return resultado;
        }

        public int devolverCantEquipos()
        {
            int resultado = 0;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();

            try
            {
                string sql = "select max(idEquipo) from equipo";
                MySqlCommand cmd = new MySqlCommand(sql, cone);
                cmd.ExecuteNonQuery();
                int cantEquipos = int.Parse(cmd.ExecuteScalar().ToString());
                return cantEquipos;
            }
            catch (MySqlException ex)
            {

            }
            return resultado;
        }

        private int crearSeleccion(int nuevoId, string disciplina, string nombre)
        {
            int devolver = 0;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sentencia = "INSERT INTO seleccion(idSeleccion, disciplina, nombre) VALUES (@idSeleccion, @disciplina, @nombre)";
            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            cmd.Parameters.AddWithValue("@idSeleccion", nuevoId);
            cmd.Parameters.AddWithValue("@disciplina", disciplina);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            devolver = cmd.ExecuteNonQuery();
            return devolver;
        }

        public int crearCuadro(int nuevoId, string disciplina, string nombre, int idLiga, string liga, string pais)
        {
            int devolver = 0;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sentencia = "INSERT INTO cuadro(idEquipo, disciplina, nombre, idLiga, nombreLiga, pais) VALUES (@idEquipo, @disciplina, @nombre, @idLiga, @nombreLiga, @pais)";
                MySqlCommand cmd = new MySqlCommand(sentencia, cone);
                cmd.Parameters.AddWithValue("@idEquipo", nuevoId);
                cmd.Parameters.AddWithValue("@disciplina", disciplina);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@idLiga", idLiga);
                cmd.Parameters.AddWithValue("@nombreLiga", liga);
                cmd.Parameters.AddWithValue("@pais", pais);
                devolver = cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {

            }
            return devolver;
        }

        public DataTable llenarDatosEquipo(DataTable tabla, string mostrar)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            MySqlCommand cmd;
            MySqlDataAdapter adapter;
            try
            {
                if (mostrar == "Seleccion")
                {
                    string sentencia = "select * from equipo where tipo='Seleccion'";
                    cmd = new MySqlCommand(sentencia, cone);
                    adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(tabla);
                }
                else
                {
                    if (mostrar == "Cuadro")
                    {
                        string sentencia = "select * from cuadro";
                        cmd = new MySqlCommand(sentencia, cone);
                        adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(tabla);
                    }
                    else
                    {
                        if (mostrar == "Todos")
                        {
                            string sentencia = "select * from equipo";
                            cmd = new MySqlCommand(sentencia, cone);
                            adapter = new MySqlDataAdapter(cmd);
                            adapter.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                cone.Close();
            }
            return tabla;
        }

        public DataTable mostrarPaises(DataTable tabla)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sentencia = "select distinct nombre from seleccion";
                MySqlCommand cmd = new MySqlCommand(sentencia, cone);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(tabla);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                cone.Close();
            }
            return tabla;
        }

        public DataTable datosPaises(DataTable tabla, string nombre)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sentencia = "select * from seleccion where nombre='" + nombre + "'";
                MySqlCommand cmd = new MySqlCommand(sentencia, cone);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(tabla);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                cone.Close();
            }
            return tabla;
        }

        public DataTable datosPaisesDeportes(DataTable tabla, string nombre)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sentencia = "select * from seleccion where disciplina='" + nombre + "'";
                MySqlCommand cmd = new MySqlCommand(sentencia, cone);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(tabla);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                cone.Close();
            }
            return tabla;
        }

        public DataTable datosDeportesActuales(DataTable tabla, int opcion)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sentencia;
            MySqlCommand cmd;
            MySqlDataAdapter adapter;
            try
            {
                if(opcion == 1)
                {
                    sentencia = "select distinct disciplina from equipo;";
                    cmd = new MySqlCommand(sentencia, cone);
                    adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(tabla);
                } else
                {
                    if(opcion == 2)
                    {
                        sentencia = "select distinct disciplina from seleccion;";
                        cmd = new MySqlCommand(sentencia, cone);
                        adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                cone.Close();
            }
            return tabla;
        }

        public DataTable ligasDisponibles(DataTable tabla, string deporte)
        {           
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sentencia = "select distinct nombreLiga from cuadro where disciplina='"+deporte+"'";
                MySqlCommand cmd = new MySqlCommand(sentencia, cone);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                tabla = new DataTable();
                adapter.Fill(tabla);
                if(tabla.Rows.Count > 1)
                {
                    return tabla;
                } 
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                cone.Close();
            }
            return tabla;
        }

        public DataTable mostrarEquipos(DataTable tabla, string disciplina, string liga)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sentencia = "select * from cuadro where disciplina='"+disciplina+"' and nombreLiga='"+liga+"'";
                MySqlCommand cmd = new MySqlCommand(sentencia, cone);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(tabla);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                cone.Close();
            }
            return tabla;
        }

        public DataTable mostrarPaisesyDeportes(DataTable tabla, string deporte)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sentencia = "select * from seleccion where disciplina='"+deporte+"'";
                MySqlCommand cmd = new MySqlCommand(sentencia, cone);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(tabla);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                cone.Close();
            }
            return tabla;
        }  

        public int crearJugador(string nombre, string apellido, string edad, string fechaNac, string rol, string altura, string peso, string pais_origen, string nombreCuadro, string nombreSeleccion, int tipo)
        {
            int devolver = 0;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            int idJugador = cantJugadores() + 1;
            try
            {
                string sentencia = "INSERT INTO jugador(idJugador, nombre, apellido, edad, fechaNac, rol, altura, peso, pais_origen) VALUES (@idJugador, @nombre, @apellido, @edad, @fechaNac, @rol, @altura, @peso, @pais_origen)";
                MySqlCommand cmd = new MySqlCommand(sentencia, cone);
                cmd.Parameters.AddWithValue("@idJugador", idJugador);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@edad", edad);
                cmd.Parameters.AddWithValue("@fechaNac", fechaNac);
                cmd.Parameters.AddWithValue("@rol", rol);
                cmd.Parameters.AddWithValue("@altura", altura);
                cmd.Parameters.AddWithValue("@peso", peso);
                cmd.Parameters.AddWithValue("@pais_origen", pais_origen);
                devolver = cmd.ExecuteNonQuery();
                if (tipo == 1)//Si no juega ni en cuadro ni equipo
                {
                    
                }
                else
                {
                    if (tipo == 2)//Si el jugador registrado solo juega en un cuadro/equipo
                    {
                        int idCuadro = obtenerIdEquipo(nombreCuadro, rol);
                        int idJugadorr = cantJugadores();
                        string sentencia2 = "UPDATE jugador set cuadro='" + idCuadro + "' where idJugador='" + idJugadorr + "'";
                        MySqlCommand cmd2 = new MySqlCommand(sentencia2, cone);
                        devolver = cmd2.ExecuteNonQuery();
                    }
                    else
                    {
                        if (tipo == 3)//Si el jugador registrado solo juega en una seleccion
                        {
                            int idSeleccion = obtenerIdSeleccion(nombreSeleccion, rol);
                            int idJugadorr = cantJugadores();
                            string sentencia2 = "update jugador set seleccion='"+idSeleccion+"' where idJugador='"+ idJugadorr + "'";
                            MySqlCommand cmd2 = new MySqlCommand(sentencia2, cone);
                            devolver = cmd2.ExecuteNonQuery();
                        } else
                        {
                            if (tipo == 4)
                            {
                                int idSeleccion = obtenerIdSeleccion(nombreSeleccion, rol);                               
                                int idCuadro = obtenerIdEquipo(nombreCuadro, rol);
                                int idJugadorr = cantJugadores();
                                string sentencia2 = "update jugador set cuadro='"+idCuadro+"', seleccion='"+idSeleccion+"' where idJugador='"+idJugador+"'";
                                MySqlCommand cmd2 = new MySqlCommand(sentencia2, cone);
                                devolver = cmd2.ExecuteNonQuery();
                            }
                        }                      
                    }
                }
            }
            catch (MySqlException ex)
            {

            }
            return devolver;
        }

        private int cantJugadores()
        {
            int id = 0;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sql = "select max(idJugador) from jugador";
                MySqlCommand cmd = new MySqlCommand(sql, cone);
                cmd.ExecuteNonQuery();
                id = int.Parse(cmd.ExecuteScalar().ToString());
                return id;
            }
            catch (MySqlException ex)
            {
            }
            finally
            {
                cone.Close();
            }
            return id;
        }

        public DataTable mostrarJugadoresSeleccion(DataTable tabla, string nombreSeleccion, string disciplina)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            int idSeleccion = obtenerIdSeleccion(nombreSeleccion, disciplina);
            try
            {
                string sentencia = "select * from jugador where seleccion='"+idSeleccion+"' and rol='"+disciplina+"'";
                MySqlCommand cmd = new MySqlCommand(sentencia, cone);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(tabla);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                cone.Close();
            }
            return tabla;
        }

        private int obtenerIdSeleccion(string nombreSeleccion, string disciplina)
        {
            int id = 0;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sql = "select idSeleccion from seleccion where disciplina = '"+disciplina+"' and nombre = '"+nombreSeleccion+"'";
                MySqlCommand cmd = new MySqlCommand(sql, cone);
                cmd.ExecuteNonQuery();
                id = int.Parse(cmd.ExecuteScalar().ToString());
                return id;
            }
            catch (MySqlException ex)
            {

            }
            finally
            {
                cone.Close();
            }
            return id;
        }

        private int obtenerIdEquipo(string nombreEquipo, string disciplina)
        {
            int id = 0;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sql = "select idEquipo from cuadro where nombre = '"+nombreEquipo+"' and disciplina = '"+disciplina+"'";
                MySqlCommand cmd = new MySqlCommand(sql, cone);
                cmd.ExecuteNonQuery();
                id = int.Parse(cmd.ExecuteScalar().ToString());
                return id;
            }
            catch (MySqlException ex)
            {

            }
            finally
            {
                cone.Close();
            }
            return id;
        }

        public DataTable consultarJugadorIndividual(string nombre, string apellido, DataTable tabla)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sentencia = "select * from jugador where nombre='"+nombre+"' and apellido='"+apellido+"'";
                MySqlCommand cmd = new MySqlCommand(sentencia, cone);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                tabla = new DataTable();
                adapter.Fill(tabla);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                cone.Close();
            }
            return tabla;
        }

        public DataTable equiposDeLigas(string nombreLiga, DataTable tabla)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sentencia = "select nombre from cuadro where nombreLiga='"+nombreLiga+"';";
                MySqlCommand cmd = new MySqlCommand(sentencia, cone);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                tabla = new DataTable();
                adapter.Fill(tabla);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                cone.Close();
            }
            return tabla;
        }

        public DataTable seleccionesConDisciplina(string disciplina, DataTable tabla)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sentencia = "select nombre from seleccion where disciplina ='"+disciplina+"'";
                MySqlCommand cmd = new MySqlCommand(sentencia, cone);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                tabla = new DataTable();
                adapter.Fill(tabla);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                cone.Close();
            }
            return tabla;
        }

        public DataTable consultarJugadoresEquipos(string nombreCuadro, string rol, DataTable tabla)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            int idEquipo = obtenerIdEquipo(nombreCuadro, rol);
            try
            {
                string sentencia = "select seleccion as 'idSeleccion', cuadro as 'idCuadro', idJugador, nombre, apellido, rol, altura, peso, pais_origen from jugador where cuadro='" + idEquipo+"' and rol='"+rol+"'";
                MySqlCommand cmd = new MySqlCommand(sentencia, cone);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(tabla);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                cone.Close();
            }
            return tabla;
        }

        public DataTable eliminarJugador(string nombre, string apellido, string rol, DataTable tabla)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sentencia = "select * from jugador where nombre='"+nombre+"' and apellido='"+apellido+"' and rol='"+rol+"'";
                MySqlCommand cmd = new MySqlCommand(sentencia, cone);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(tabla);               
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                cone.Close();
            }
            return tabla;
        }

        public bool idJugadorExiste(int id, string nombre, string apellido)
        {
            MySqlDataReader reader;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sentencia = "SELECT * FROM jugador WHERE idJugador='"+id+"' and nombre='"+nombre+"' and apellido='"+apellido+"'";
            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            reader = cmd.ExecuteReader();
            if (reader.HasRows) //Comprobar si hay columnas, osea que ya existe el usuario.
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool eliminarJugadorConId(int id)
        {           
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sql = "delete from jugador where idJugador='"+id+"'";
            MySqlCommand cmd = new MySqlCommand(sql, cone);
            MySqlDataReader reader = cmd.ExecuteReader();
            actualizarIdJugador(id);
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool actualizarIdJugador(int id)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            int maximo = contarJugadores();
            int empieza = id;
            MySqlCommand cmd;
            int idAnterior = empieza + 1;
            for (int x = id; x <= maximo; x++)
            {
                string sql = "update jugador set idJugador="+empieza+" where idJugador='"+idAnterior+"'";
                cmd = new MySqlCommand(sql, cone);
                cmd.ExecuteNonQuery();
                empieza += 1;
                idAnterior += 1;
            }
            return true;
        }

        private int contarJugadores()
        {
            int resultado = 0;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sql = "select count(*) from jugador";
                MySqlCommand cmd = new MySqlCommand(sql, cone);
                cmd.ExecuteNonQuery();
                int cantColumnas = int.Parse(cmd.ExecuteScalar().ToString());
                return cantColumnas;
            }
            catch (MySqlException ex)
            {

            }
            return resultado;
        }

        public bool existeSeleccion(int id, string nombre, string disciplina)
        {
            MySqlDataReader reader;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sentencia = "select * from seleccion where idSeleccion='"+id+"' and disciplina='"+disciplina+"' and nombre='"+nombre+"'";
            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            reader = cmd.ExecuteReader();
            if (reader.HasRows) //Comprobar si hay columnas, osea que ya existe el usuario.
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool eliminarSeleccion(int idSeleccion, string nomSeleccion, string rol)
        {
            eliminarJugadoresDeSeleccion(idSeleccion);
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sql = "delete from seleccion where idSeleccion='"+idSeleccion+"' and disciplina='"+rol+"' and nombre='"+nomSeleccion+"'";
            MySqlCommand cmd = new MySqlCommand(sql, cone);
            MySqlDataReader reader = cmd.ExecuteReader();
            eliminarSeleccionDeEquipo(idSeleccion); 
            if (reader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private bool eliminarJugadoresDeSeleccion(int id)
        {
            MySqlConnection cone = AfyConexion.conexion(); 
            cone.Open();
            string sql = "update jugador set seleccion=null where seleccion='"+id+"'";
            MySqlCommand cmd = new MySqlCommand(sql, cone);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool eliminarSeleccionDeEquipo(int id)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sql = "delete from equipo where idEquipo='"+id+"'";
            MySqlCommand cmd = new MySqlCommand(sql, cone);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool datosCuadroCoinciden(int id, string disciplina, string nombreCuadro, string nomLiga)
        {
            MySqlDataReader reader;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sentencia = "select * from cuadro where idEquipo='"+id+"' and disciplina='"+disciplina+"' and nombre='"+nombreCuadro+"' and nombreLiga='"+nomLiga+"'";
            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            reader = cmd.ExecuteReader();
            if (reader.HasRows) //Comprobar si hay columnas, osea que ya existe el usuario.
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool eliminarCuadro(int id, string disciplina, string nombreCuadro, string nomLiga)
        {
            eliminarJugadorDeCuadro(id);
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sql = "delete from cuadro where idEquipo='" + id + "' and disciplina='" + disciplina + "' and nombre='" + nombreCuadro + "' and nombreLiga='"+nomLiga+"'";
            MySqlCommand cmd = new MySqlCommand(sql, cone);
            MySqlDataReader reader = cmd.ExecuteReader();
            eliminarCuadroDeEquipo(id);
            if (reader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void eliminarCuadroDeEquipo(int id)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sql = "delete from equipo where idEquipo='"+id+"'";
            MySqlCommand cmd = new MySqlCommand(sql, cone);
            MySqlDataReader reader = cmd.ExecuteReader();
        }

        private void eliminarJugadorDeCuadro(int id)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sql = "update jugador set cuadro=null where cuadro='"+id+"'";
            MySqlCommand cmd = new MySqlCommand(sql, cone);
            MySqlDataReader reader = cmd.ExecuteReader();
        }

        public MySqlDataReader crearRegistroUsuarios()
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sql = "select Email, Nickname, Contrasenia, Tipo from usuario";
            MySqlCommand cmd = new MySqlCommand(sql, cone);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public DataTable seleccionVisitante(string nomSeleccionLocal, string disciplina, DataTable tabla)
        {           
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sentencia = "select nombre from seleccion where disciplina ='" + disciplina + "' and nombre <> '" + nomSeleccionLocal + "'";
                MySqlCommand cmd = new MySqlCommand(sentencia, cone);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(tabla);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                cone.Close();
            }
            return tabla;
        }

        public DataTable jugadoresInvidualLocal(string disciplina, DataTable tabla)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sentencia = "select nombre,apellido,idJugador,pais_origen from jugador where rol = '" + disciplina+"'";
                MySqlCommand cmd = new MySqlCommand(sentencia, cone);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(tabla);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                cone.Close();
            }
            return tabla;
        }

        public bool comprobarCredencialesJugador(int id, string nombre, string apellido)
        {
            MySqlDataReader reader;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sentencia = "select * from jugador where idJugador='"+id+"' and nombre='"+nombre+"' and apellido='"+apellido+"'";
            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            reader = cmd.ExecuteReader();
            if (reader.HasRows) //Comprobar si hay columnas, osea que ya existe el usuario.
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable mostrarVisitantes(int id, string rol, DataTable tabla)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sentencia = "select nombre,apellido,idJugador,pais_origen from jugador where rol='" + rol+"' and idJugador <> '"+id+"'";
                MySqlCommand cmd = new MySqlCommand(sentencia, cone);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(tabla);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                cone.Close();
            }
            return tabla;
        }

        public string crearEventoTablaAuxIndividual(int idEvento, int idLocal, int resultado_local, int idVisitante, int resultado_vis, string fecha, string deporte)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            borrarFila(idEvento, 1);
            string sentencia = "insert into encuentro_individualesActivos(idEvento, idJugador1_local, resultado_jugador1, idJugador2_visitante, resultado_jugador2, fecha, deporte) values (@idEvento, @idJugador1_local, @resultado_jugador1, @idJugador2_visitante, @resultado_jugador2, @fecha, @deporte);";
            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            cmd.Parameters.AddWithValue("@idEvento", idEvento);
            cmd.Parameters.AddWithValue("@idJugador1_local", idLocal);
            cmd.Parameters.AddWithValue("@resultado_jugador1", resultado_local);
            cmd.Parameters.AddWithValue("@idJugador2_visitante", idVisitante);
            cmd.Parameters.AddWithValue("@resultado_jugador2", resultado_vis);
            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@deporte", deporte);
            int insertar = cmd.ExecuteNonQuery();
            return "";
        }

        public string crearEventoTablaAuxEquipos(int idEvento, string fecha, string nomSelLocal, string alineacion_local, int resultado_local, string nomSelVis, string alineacion_vis, int resultado_vis, string deporte)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            borrarFila(idEvento, 2);
            int idSelLocal = obtenerIdEquiposSelecciones(nomSelLocal, deporte);
            int idSelVis = obtenerIdEquiposSelecciones(nomSelVis, deporte);
            string sentencia = "insert into encuentro_equiposactivos(idEvento, fecha, idEquipo1_local, resultado_local, idEquipo2_visitante, resultado_visitante, deporte) values (@idEvento, @fecha, @idEquipo1_local, @resultado_local, @idEquipo2_visitante, @resultado_visitante, @deporte);";
            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            cmd.Parameters.AddWithValue("@idEvento", idEvento);
            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@idEquipo1_local", idSelLocal);
            cmd.Parameters.AddWithValue("@resultado_local", resultado_local);
            cmd.Parameters.AddWithValue("@idEquipo2_visitante", idSelVis);
            cmd.Parameters.AddWithValue("@resultado_visitante", resultado_vis);
            cmd.Parameters.AddWithValue("@deporte", deporte);
            int insertar = cmd.ExecuteNonQuery();
            if(deporte == "Futbol" || deporte == "Hockey" || deporte == "HandBall" || deporte == "Rugby")
            {
                string sql = "update encuentro_equiposactivos set alineacion_local='" + alineacion_local + "', alineacion_visitante='" + alineacion_vis + "' where idEvento='" + idEvento + "'";
                cmd = new MySqlCommand(sql, cone);
                cmd.ExecuteNonQuery();
            }
            return "";
        }

        private int obtenerIdEquiposSelecciones(string nomSel, string deporte)
        {
            int id = 0;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sql = "select idEquipo from equipo where disciplina='"+deporte+"' and nombre='"+nomSel+"'";
                MySqlCommand cmd = new MySqlCommand(sql, cone);
                cmd.ExecuteNonQuery();
                id = int.Parse(cmd.ExecuteScalar().ToString());
                return id;
            }
            catch (MySqlException ex)
            {

            }
            finally
            {
                cone.Close();
            }
            return id;
        }

        public bool borrarFila(int idEvento, int cual)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sql = "";
            MySqlCommand cmd;
            if(cual == 1)
            {
                sql = "delete from encuentro_individualesactivos where idEvento='" + idEvento + "'";
                cmd = new MySqlCommand(sql, cone);
                cmd.ExecuteNonQuery();
            } else
            {
                if(cual == 2)
                {
                    sql = "delete from encuentro_equiposactivos where idEvento='" + idEvento + "'";
                    cmd = new MySqlCommand(sql, cone);
                    cmd.ExecuteNonQuery();
                }
            }           
            return false;
        }

        private int cantEvento()
        {
            int id = 0;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sql = "select count(*) from encuentro_individualesActivos";
                MySqlCommand cmd = new MySqlCommand(sql, cone);
                cmd.ExecuteNonQuery();
                id = int.Parse(cmd.ExecuteScalar().ToString());
                return id;
            }
            catch (MySqlException ex)
            {

            }
            finally
            {
                cone.Close();
            }
            return id;
        }

        public MySqlDataReader devolverDatosEventos(int id)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sentencia = "select idJugador1_local, resultado_jugador1, idJugador2_visitante, resultado_jugador2, fecha, deporte from encuentro_individualesActivos where idEvento='"+id+"'";
            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public MySqlDataReader devolverDatosEventosEquipos(int id)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sentencia = "select fecha, idEquipo1_local, resultado_local, idEquipo2_visitante, resultado_visitante, deporte from encuentro_equiposactivos where idEvento='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public string obtenerNombreDeJugador(int id)
        {
            MySqlDataReader reader;
            string nombre = "";
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sentencia = "select concat(nombre,' ',apellido) completo from jugador where idJugador="+id+" order by completo";
                MySqlCommand cmd = new MySqlCommand(sentencia, cone);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    nombre = reader[0].ToString();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                cone.Close();
            }
            return nombre;
        }

        public string obtenerNombreDeSeleccion(int id)
        {
            MySqlDataReader reader;
            string nombre = "";
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sentencia = "select nombre from equipo where idEquipo='"+id+"'";
                MySqlCommand cmd = new MySqlCommand(sentencia, cone);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    nombre = reader[0].ToString();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                cone.Close();
            }
            return nombre;
        }

        //public bool actualizarValorEventoEquipo(int idEvento, string localOVis, int valor)
        //{
        //    MySqlConnection cone = AfyConexion.conexion();
        //    cone.Open();
        //    string sentencia = "";
        //    MySqlCommand cmd;// = new MySqlCommand(sentencia, cone);
        //    if (localOVis == "local")
        //    {
        //        sentencia = "update encuentro_individualesactivos set resultado_jugador1='" + valor + "' where idEvento='" + idEvento + "'";
        //        cmd = new MySqlCommand(sentencia, cone);
        //        cmd.ExecuteNonQuery();
        //    }
        //    else
        //    {
        //        if (localOVis == "visitante")
        //        {
        //            sentencia = "update encuentro_individualesactivos set resultado_jugador2='" + valor + "' where idEvento='" + idEvento + "'";
        //            cmd = new MySqlCommand(sentencia, cone);
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    return false;
        //}

        public bool actualizarValorEvento(int idEvento, string localOVisitante, int valor)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sentencia = "";
            MySqlCommand cmd;// = new MySqlCommand(sentencia, cone);
            if(localOVisitante == "local")
            {
                sentencia = "update encuentro_individualesactivos set resultado_jugador1='" + valor + "' where idEvento='" + idEvento + "'";
                cmd = new MySqlCommand(sentencia, cone);
                cmd.ExecuteNonQuery();
            }
            else
            {
                if (localOVisitante == "visitante")
                {
                    sentencia = "update encuentro_individualesactivos set resultado_jugador2='" + valor + "' where idEvento='" + idEvento + "'";
                    cmd = new MySqlCommand(sentencia, cone);
                    cmd.ExecuteNonQuery();
                }
            }
            return false;
        }

        public bool actualizarValorEventoEquipos(int idEvento, string localOVisitante, int valor)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sentencia = "";
            MySqlCommand cmd;// = new MySqlCommand(sentencia, cone);
            if (localOVisitante == "local")
            {
                sentencia = "update encuentro_equiposactivos set resultado_local='" + valor + "' where idEvento='" + idEvento + "'";
                cmd = new MySqlCommand(sentencia, cone);
                cmd.ExecuteNonQuery();
            }
            else
            {
                if (localOVisitante == "visitante")
                {
                    sentencia = "update encuentro_equiposactivos set resultado_visitante='" + valor + "' where idEvento='" + idEvento + "'";
                    cmd = new MySqlCommand(sentencia, cone);
                    cmd.ExecuteNonQuery();
                }
            }
            return false;
        }

        public bool hayEvento(int idevento)
        {
            MySqlDataReader reader;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sentencia = "select * from encuentro_individualesactivos where idEvento='"+idevento+"'";
            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            reader = cmd.ExecuteReader();
            if (reader.HasRows) //Comprobar si hay columnas, osea que ya existe el usuario.
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool hayEventoEquipos(int idevento)
        {
            MySqlDataReader reader;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sentencia = "select * from encuentro_equiposactivos where idEvento='" + idevento + "'";
            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int cantEventosGeneral()
        {
            int id = 0;
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sql = "select count(*) from evento";
                MySqlCommand cmd = new MySqlCommand(sql, cone);
                cmd.ExecuteNonQuery();
                id = int.Parse(cmd.ExecuteScalar().ToString());
                return id;
            }
            catch (MySqlException ex)
            {

            }
            finally
            {
                cone.Close();
            }
            return id;
        }

        private int crearEventoPrincipal(int idEvento, string deporte, string fecha, string tipo)
        {
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            string sentencia = "insert into evento(idEvento, deporte, fecha, tipo) values (@idEvento, @deporte, @fecha, @tipo)";
            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            cmd.Parameters.AddWithValue("@idEvento", idEvento);
            cmd.Parameters.AddWithValue("@deporte", deporte);
            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            int insertar = cmd.ExecuteNonQuery();
            return 2;
        }

        public string crearEventoEquipos(string fecha, int idEquipo1_local, int resultado_local, int idEquipo2_visitante, int resultado_visitante, string deporte, int idBorrar)
        {
            string tipo = "Equipo";
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            int idEvento = cantEventosGeneral() + 1;
            crearEventoPrincipal(idEvento, deporte, fecha, tipo);
            string sentencia = "insert into encuentro_equipos(idEvento, fecha, idEquipo1_local, resultado_local, idEquipo2_visitante, resultado_visitante, deporte) values (@idEvento, @fecha, @idEquipo1_local, @resultado_local, @idEquipo2_visitante, @resultado_visitante, @deporte)";
            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            cmd.Parameters.AddWithValue("@idEvento", idEvento);
            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@idEquipo1_local", idEquipo1_local);
            cmd.Parameters.AddWithValue("@resultado_local", resultado_local);
            cmd.Parameters.AddWithValue("@idEquipo2_visitante", idEquipo2_visitante);
            cmd.Parameters.AddWithValue("@resultado_visitante", resultado_visitante);
            cmd.Parameters.AddWithValue("@deporte", deporte);
            int insertar = cmd.ExecuteNonQuery();
            borrarFila(idBorrar, 2);
            return "";
        }

        public string crearEventoIndividual(string fecha, int idJugador1_local, int resultado_local, int idJugador2_visitante, int resultado_visitante, string deporte, int idBorrar)
        {
            string tipo = "Individual";
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            int idEvento = cantEventosGeneral() + 1;
            crearEventoPrincipal(idEvento, deporte, fecha, tipo);
            string sentencia = "insert into encuentro_individual(idEvento, idJugador1_local, resultado_jugador1, idJugador2_visitante, resultado_jugador2, fecha, deporte) values (@idEvento, @idJugador1_local, @resultado_jugador1, @idJugador2_visitante, @resultado_jugador2, @fecha, @deporte)";
            MySqlCommand cmd = new MySqlCommand(sentencia, cone);
            cmd.Parameters.AddWithValue("@idEvento", idEvento);
            cmd.Parameters.AddWithValue("@idJugador1_local", idJugador1_local);
            cmd.Parameters.AddWithValue("@resultado_jugador1", resultado_local);
            cmd.Parameters.AddWithValue("@idJugador2_visitante", idJugador2_visitante);
            cmd.Parameters.AddWithValue("@resultado_jugador2", resultado_visitante);
            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@deporte", deporte);
            int insertar = cmd.ExecuteNonQuery();
            borrarFila(idBorrar, 1);
            return "";
        }

        public string nombreDeSeleccion(int id)
        {
            MySqlDataReader reader;
            string nombre = "";
            MySqlConnection cone = AfyConexion.conexion();
            cone.Open();
            try
            {
                string sentencia = "select nombre from equipo where idEquipo='"+id+"'";
                MySqlCommand cmd = new MySqlCommand(sentencia, cone);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    nombre = reader[0].ToString();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                cone.Close();
            }
            return nombre;
        }

    }
}       
