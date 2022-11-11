using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Afy
{
    class AfyConsultaSQL //Manejo de excepciones y comunicación con BD
    {
        public string Registro(AfyUsuario usuario) //Comprobar credenciales(Registro)
        {
            AfySQL afyi = new AfySQL();
            string resultado = "";
            string emailTemporal = usuario.Email;
            string emailEnvio = usuario.Email;

            bool emailCorrecto = IsValidEmail(emailTemporal);
            if (string.IsNullOrEmpty(usuario.Email) || string.IsNullOrEmpty(usuario.Usuario) || string.IsNullOrEmpty(usuario.Contrasenia) || string.IsNullOrEmpty(usuario.ConfirmarContrasenia)) //Comprobar campos vacios
            {
                resultado = "Por favor complete todos los campos.";
            } else if (emailCorrecto == true)
            {
                if (usuario.Contrasenia == usuario.ConfirmarContrasenia)
                {
                    if (afyi.mailExiste(usuario.Email)) //Comprobar si ya existe un usuario con el nombre.
                    {
                        resultado = "El Email ya está registrado.";
                    } else
                    {
                        if (afyi.usuarioExiste(usuario.Usuario)) //Comprobar si ya existe un usuario con el nombre.
                        {
                            resultado = "El usuario ya existe.";
                        }
                        else
                        {
                            try
                            {
                                DateTime fecha = DateTime.Today;
                                string formato = "yyyy-MM-dd";
                                usuario.FechaRegistro = System.DateTime.Parse(fecha.ToString(formato));
                                usuario.Tipo = "U-NoSuscrito";
                                int aux = afyi.registrar(usuario); //Creo el usuario y lo agrego a la DB
                                if (aux > 0)
                                {
                                    AfyEnvioMail afye = new AfyEnvioMail();
                                    //afye.enviarMailRegistro(usuario.Email, usuario.Usuario); //Envio email.
                                    resultado = "ok";
                                }
                                else
                                {
                                    resultado = "Error";
                                }
                            }
                            catch (Exception ex)
                            {
                                resultado = ex.ToString();
                            }
                        }
                    }
                } else
                {
                    resultado = "Las contraseñas no coinciden.";
                }
            } else
            {
                resultado = "Ingrese un Email correcto.";
            }

            return resultado;
        }

        public string Login(string nickname, string contrasenia) //Comprobar credenciales(Login)
        {
            AfySQL afysql = new AfySQL();
            string resultado = "error";
            AfyUsuario usuarioLogin = new AfyUsuario();

            if (string.IsNullOrEmpty(nickname) || string.IsNullOrEmpty(contrasenia))
            {
                resultado = "LLene todos los campos.";
            } else
            {
                usuarioLogin = afysql.login(nickname);

                if (usuarioLogin == null) //No existe el usuario.
                {
                    resultado = "El usuario no existe.";
                } else
                {
                    if (usuarioLogin.Contrasenia != contrasenia) //No coinciden.
                    {
                        resultado = "Ningun usuario y contraseña coinciden";
                    } else //Coincide
                    {
                        resultado = "Coincide";
                        AfySesion.Email = usuarioLogin.Email;
                        AfySesion.usuario = usuarioLogin.Usuario;
                        AfySesion.contrasenia = usuarioLogin.Contrasenia;
                        AfySesion.tipo = usuarioLogin.Tipo;
                    }
                }
            }
            return resultado;
        }

        bool IsValidEmail(string email) //Validar si la escritura de Email es correcta.
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public string mostrarUsuarios(string usuariosMostrar)
        {
            string devolver = "";
            AfySQL afy = new AfySQL();
            string enviar = usuariosMostrar;
            if (usuariosMostrar == "U-NoSuscrito")
            {
                devolver = afy.MostrarUsuarios(enviar);
            }
            else
            {
                if (usuariosMostrar == "U-Suscrito")
                {
                    devolver = afy.MostrarUsuarios(usuariosMostrar);
                }
                else
                {
                    if (usuariosMostrar == "Admin")
                    {
                        devolver = afy.MostrarUsuarios(usuariosMostrar);
                    } else
                    {
                        if (usuariosMostrar == "Todos")
                            devolver = afy.MostrarUsuarios(usuariosMostrar);
                    }
                }
            }
            return devolver;
        } //Devolver usuarios a mostrar

        public string controlSuscripcion(string email, string usuario, string contrasenia, string tipoTarjeta, string numero_tarjeta, string fechaVencimientoTarjeta)
        {
            string resultado = "";
            string emailTemporal = email;
            bool emailCorrecto = IsValidEmail(emailTemporal);
            string nombreUsuario = AfySesion.usuario, emailUsuario = AfySesion.Email, contraUsuario = AfySesion.contrasenia;
            AfySQL afysql = new AfySQL();

            if (nombreUsuario != usuario)
            {
                resultado = "El usuario no coincide";
            } else
            {
                if (emailCorrecto == true)
                {
                    if (email == emailUsuario)
                    {
                        if (contraUsuario == contrasenia)
                        {
                            string numeroTarjeta = numero_tarjeta;
                            string fechaVecTarjeta = fechaVencimientoTarjeta;

                            bool agregoMailSuscriptor = afysql.agregarMailSuscriptor(emailUsuario); //Agrego a la tabla "Suscripto" el email

                            int agregarTarjeta = afysql.agregarTarjeta(emailUsuario, tipoTarjeta, numeroTarjeta, fechaVecTarjeta); //Agrego tarjeta con datos a tabla

                            bool actualizarSuscriptor = afysql.actualizarSuscriptor(emailUsuario); //Actualizo estado de suscripcion a suscrito.  

                            int suscripcionDatos = afysql.suscripcionDatos(numeroTarjeta, emailUsuario); //Agrego a tabla suscripcion con respectivos datos.

                            int utilizaRelacion = afysql.utiliza(emailUsuario, numeroTarjeta); //Se agrega a la relacion Utiliza

                            if (agregoMailSuscriptor == true && agregarTarjeta == 0 && actualizarSuscriptor == true && suscripcionDatos == 0)
                            {
                                resultado = "Error";
                            } else
                            {
                                resultado = "ok";
                                AfyEnvioMail afye = new AfyEnvioMail();
                                //afye.enviarMailSuscripcion(emailUsuario, nombreUsuario);
                            }
                        } else
                        {
                            resultado = "La contraseña no coincide";
                        }
                    } else
                    {
                        resultado = "Gmail No coincide";
                    }
                } else
                {
                    resultado = "Email Incorrecto";
                }
            }

            return resultado;
        } //Control crear usuario suscrito

        public string eliminarControl(string Email, string usuario, string codigo)
        {
            AfySQL afy = new AfySQL();
            string emailAuxiliar = Email;
            bool emailCorrecto = IsValidEmail(emailAuxiliar);
            const string codigoSeguridad = "aaaa";
            string respuesta = "";
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(codigo))
            {
                respuesta = "Por favor llene todos los campos";
            }
            else
            {
                if (emailCorrecto != true)
                {
                    respuesta = "La dirección de correo no es válida.";
                } else
                {
                    if(codigo == codigoSeguridad)
                    {
                        string emailBien = emailAuxiliar;
                        bool comprobarUsuario = afy.usuarioExiste(usuario); //Comprobar si el usuario existe
                        bool comprobarMail = afy.mailExiste(emailBien); //Comprobar si el mail existe
                        if (comprobarUsuario == true && comprobarMail == true)
                        {
                            try
                            {
                                int comprobarSuscripto = afy.mailSuscriptoExiste(emailBien); //Compruebo si el mail está suscripto
                                if (comprobarSuscripto > 0) //Si es 1, está suscripto. Si es 0 NO
                                {
                                    int aux1 = afy.eliminarUsuarioSuscripto(emailBien, usuario);
                                    int aux2 = afy.eliminarSuscriptorTablaUtiliza(emailBien);
                                    int aux3 = afy.eliminarSuscriptorTablaTarjetacredito(emailBien);
                                    int aux4 = afy.eliminarSuscriptorTablaSuscripto(emailBien);
                                    int aux5 = afy.EliminarUsuario(emailBien, usuario);
                                    if (aux1 == 0 && aux2 == 0 && aux3 == 0 && aux4 == 0 && aux5 == 0)
                                    {
                                        respuesta = "ok";
                                    }
                                    else
                                    {
                                        respuesta = "Error";
                                    }
                                }
                                else
                                {
                                    int aux = afy.EliminarUsuario(emailBien, usuario);
                                    if (aux == 0)
                                    {
                                        respuesta = "ok";
                                    }
                                    else
                                    {
                                        respuesta = "Error";
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                respuesta = ex.ToString();
                            }
                        }
                        else
                        {
                            respuesta = "El email o usuario no existe.";
                        }
                    } else
                    {
                        respuesta = "El código de seguridad es incorrecto";
                    }                
                }
            }
            return respuesta;
        }  //Control para eliminar usuarios

        public string nuevoAdmin(string email, string usuario, string codigo)
        {
            const string codigoSeguridad = "bbbb";
            AfySQL afy = new AfySQL();
            string resultado = "";
            string emailAux = email;
            bool emailCorrecto = IsValidEmail(emailAux);
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(codigo))
            {
                resultado = "Complete todos los espacios";
            } else
            {
                if (emailCorrecto != true)
                {
                    resultado = "El formato de email es incorrecto";
                } else
                {
                    if(codigo != codigoSeguridad)
                    {
                        resultado = "El código de seguridad es erroneo";
                    } else
                    {
                        bool usuarioExiste = afy.usuarioExiste(usuario);
                        bool mailExiste = afy.mailExiste(email);
                        if (usuarioExiste != true)
                        {
                            resultado = "El usuario no existe.";
                        }
                        else
                        {
                            if (mailExiste != true)
                            {
                                resultado = "El email no existe.";
                            }
                            else
                            {
                                try
                                {
                                    int aux = afy.crearNuevoAdmin(email, usuario);
                                    if (aux == 0)
                                    {
                                        resultado = "ok";
                                    }
                                    else
                                    {
                                        resultado = "Error";
                                    }
                                }
                                catch (Exception ex)
                                {
                                    resultado = ex.ToString();
                                }
                            }
                        }
                    }                   
                }
            }
            return resultado;
        } //Creacion de nuevo admin

        public string sacarAdmin(string email, string usuario)
        {
            AfySQL afy = new AfySQL();
            string resultado = "";
            string emailAux = email;
            bool emailCorrecto = IsValidEmail(emailAux);
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(usuario))
            {
                resultado = "Complete todos los campos";
            } else
            {
                if (emailCorrecto != true)
                {
                    resultado = "El formato de email no es correcto.";
                } else
                {
                    if (afy.usuarioExiste(usuario) != true || afy.mailExiste(email) != true) //Si no existe el mail o usuario
                    {
                        resultado = "El usuario o el Email no existe..";
                    } else
                    {
                        try
                        {
                            if (afy.sacarPermisoAdmin(email, usuario) == 0) //Si es 0, se sacó el permiso de administrador, si es 1 dio ERROR.
                            {
                                resultado = "ok";
                            }
                            else
                            {
                                resultado = "Error";
                            }
                        }
                        catch (Exception ex)
                        {
                            resultado = ex.ToString();
                        }
                    }
                }
            }
            return resultado;
        } //Sacar permiso de admin

        public string recuperarUsuario(string email)
        {
            AfySQL afy = new AfySQL();
            string resultado = "";
            bool emailCorrecto = IsValidEmail(email);
            if (string.IsNullOrEmpty(email))
            {
                resultado = "Ingrese un email";
            } else
            {
                if (emailCorrecto != true)
                {
                    resultado = "El email es incorrecto";
                } else
                {
                    if (afy.mailExiste(email) == true)
                    {
                        //afy.enviarMailRecuperacion(email);
                        resultado = "ok";
                    } else
                    {
                        resultado = "El email no existe.";
                    }
                }
            }
            return resultado;
        } //Enviar información a mail

        public string agregarPublicidad(string nombre, byte[] imagen)
        {
            AfySQL afy = new AfySQL();
            string resultado = "";
            int idNuevo = cantidadImagenes();
            if (string.IsNullOrEmpty(nombre))
            {
                resultado = "Agregue un nombre para la publicidad";
            } else
            {
                if(comprobarNumeros(nombre) == true)
                {
                    resultado = "El nombre de la imagen no puede tener solo números.";
                } else
                {
                    if (imagen == null)
                    {
                        resultado = "Agregue una imagen.";
                    }
                    else
                    {
                        string respuesta = afy.agregarPublicidad(idNuevo, nombre, imagen);
                        if (respuesta == "ok")
                        {
                            resultado = "ok";
                        }
                        else
                        {
                            resultado = respuesta;
                        }
                    }
                }              
            }
            return resultado;
        } //Agrego imagen a tabla

        public int cantidadImagenes()
        {
            AfySQL afy = new AfySQL();
            int respuesta = afy.contarImagenesPublicidad();
            return respuesta;
        } //Devuelve la cantidad de filas que hay

        public MemoryStream mostrarImagen(int id)
        {
            AfySQL afy = new AfySQL();
            MemoryStream imagen = afy.mostrarImagen(id);
            return imagen;
        }   //Muestra la imagen

        public string nombrePublicidad(int id)
        {
            string respuesta = "";
            AfySQL afy = new AfySQL();
            respuesta = afy.nombrePublicidad(id);
            return respuesta;
        }  //Devuelve nombre de publicidad

        public string eliminarPublicidad(string idPublicidad)
        {
            string resultado = "";
            AfySQL a = new AfySQL();            

            if (string.IsNullOrEmpty(idPublicidad))
            {
                resultado = "Ingrese un numero de publicidad";
            } else
            {
                if(comprobarNumeros(idPublicidad) == true)
                {
                    int convertir = int.Parse(idPublicidad);
                    bool respuesta = a.eliminarPublicidad(convertir);
                    if (respuesta == true)
                    {
                        resultado = "ok";
                    }
                    else
                    {
                        resultado = "el ID de imagen no existe.";
                    }
                } else
                {
                    resultado = "Ingrese un número no letra.";
                }
            }           
            return resultado;
        }  //Elimina la publicidad con el ID

        public string crearLiga(string nombre, string deporte, string pais)
        {
            string resultado = "";
            AfySQL a = new AfySQL();
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(deporte) || string.IsNullOrEmpty(pais)){
                resultado = "Complete todos los campos";
            } else
            {
                if(comprobarNumeros(nombre) == true || comprobarNumeros(pais) == true)
                {
                    resultado = "El pais o el nombre de la liga no pueden ser números";
                } else
                {
                    if (a.comprobarLigaExiste(nombre, deporte, pais) == true)
                    {
                        resultado = "La liga ya existe.";
                    }
                    else
                    {
                        a.crearLiga(nombre, deporte, pais);
                        resultado = "ok";
                    }
                }                               
            }
            return resultado;
        }

        public DataTable ligas(DataTable valor, string deporte)
        {
            AfySQL a = new AfySQL();
            valor = a.ligas(valor, deporte);
            return valor;
        }

        private bool comprobarNumeros(string cadena)
        {
            int aux;
            if (Int32.TryParse(cadena, out aux) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string crearSeleccion(string disciplina, string nombre, string tipo)
        {
            AfySQL a = new AfySQL();
            string devolver = "";
            if(string.IsNullOrEmpty(disciplina) || string.IsNullOrEmpty(nombre))
            {
                devolver = "Complete todos los campos";
            } else
            {
                if(comprobarNumeros(nombre) == true)
                {
                    devolver = "El nombre de la selección no puede ser solo números";
                } else
                {
                    if (a.comprobarSeleccionExiste(nombre, disciplina) == true)
                    {
                        devolver = "La selección en ese deporta ya existe.";
                    }
                    else
                    {
                        int nuevoId = a.devolverCantEquipos() + 1;
                        a.crearEquipo(nuevoId, disciplina, nombre, tipo);
                        devolver = "ok";
                    }
                }
            }          
            return devolver;
        }

        public string crearCuadro(string disciplina, string nombre, string liga, string tipo, string pais)
        {
            AfySQL a = new AfySQL();
            string devolver = "";
            if(string.IsNullOrEmpty(disciplina) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(liga) || string.IsNullOrEmpty(pais))
            {
                devolver = "Complete todos los campos";
            } else
            {
                int id = a.devolverIdLiga(liga);
                if (id < 1)
                {
                    devolver = "La liga no existe.";
                }
                else
                {
                    if(comprobarNumeros(nombre) == true || comprobarNumeros(pais) == true)
                    {
                        devolver = "El nombre del equipo o liga no pueden ser solo números";
                    } else
                    {
                        if (a.comprobarCuadroExiste(disciplina, nombre, liga) == true)
                        {
                            devolver = "El cuadro ya existe.";
                        }
                        else
                        {
                            int nuevoId = a.devolverCantEquipos() + 1;
                            a.crearEquipo(nuevoId, disciplina, nombre, tipo);
                            a.crearCuadro(nuevoId, disciplina, nombre, id, liga, pais);
                            devolver = "ok";
                        }
                    }
                }
            }
            return devolver;
        }  

        public DataTable datosEquipos(DataTable llenar, string dato)
        {
            AfySQL a = new AfySQL();
            llenar = a.llenarDatosEquipo(llenar, dato);
            return llenar;
        }

        public DataTable mostrarPaises(DataTable tabla)
        {
            AfySQL a = new AfySQL();
            tabla = a.mostrarPaises(tabla);
            return tabla;
        }

        public DataTable datosPaisesDeportes(DataTable tabla, string deporte)
        {
            AfySQL a = new AfySQL();
            tabla = a.datosPaisesDeportes(tabla, deporte);
            return tabla;
        }

        public DataTable datosPaises(DataTable tabla, string pais)
        {
            AfySQL a = new AfySQL();
            tabla = a.datosPaises(tabla, pais);
            return tabla;
        }  

        public DataTable deportesConDatos(DataTable tabla, int opcion)
        {
            AfySQL a = new AfySQL();
            tabla = a.datosDeportesActuales(tabla, opcion);
            return tabla;
        }  

        public DataTable ligasDisponibles(DataTable tabla, string deporte)
        {
            AfySQL a = new AfySQL();
            tabla = a.ligasDisponibles(tabla, deporte);
            return tabla;
        }

        public DataTable mostrarCuadros(DataTable tabla, string disciplina, string liga)
        {
            AfySQL a = new AfySQL();
            tabla = a.mostrarEquipos(tabla, disciplina, liga);
            return tabla;
        }

        public DataTable datosPaisesYDeportes(DataTable tabla, string pais)
        {
            AfySQL a = new AfySQL();
            tabla = a.mostrarPaisesyDeportes(tabla, pais);
            return tabla;
        }

        public string crearJugador(string nombre, string apellido, string edad, string fechaNac, string rol, string altura, string peso, string pais_origen, string nombreCuadro, string nombreSeleccion, int tipo)
        {
            AfySQL a = new AfySQL();
            string devolver = "";
            if(string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(Convert.ToString(edad))
            || string.IsNullOrEmpty(fechaNac)  || string.IsNullOrEmpty(rol) || string.IsNullOrEmpty(altura)
            || string.IsNullOrEmpty(peso) || string.IsNullOrEmpty(pais_origen) || string.IsNullOrEmpty(nombreCuadro) || string.IsNullOrEmpty(nombreSeleccion))
            {
                devolver = "Complete todos los campos";
            } else
            {
                if(comprobarNumeros(nombre) == true)
                {
                    devolver = "El nombre no puede contener números";
                } else
                {
                    if(comprobarNumeros(apellido) == true)
                    {
                        devolver = "El apellido no puede contener números";
                    } else
                    {
                        if(comprobarNumeros(edad) == false)
                        {
                            devolver = "La edad solo pueden ser números";
                        } else
                        {
                            if(comprobarNumeros(altura) == false)
                            {
                                devolver = "La altura solo pueden ser números";
                            } else
                            {
                                if(comprobarNumeros(peso) == false)
                                {
                                    devolver = "El peso solo pueden ser números";
                                } else
                                {
                                    if(comprobarNumeros(pais_origen) == true)
                                    {
                                        devolver = "El país no puede contener números";
                                    } else
                                    {
                                        if (tipo == 1)
                                        {
                                            if (rol == "Tenis" || rol == "PingPong" || rol == "Boxeo")
                                            {                                               
                                                a.crearJugador(nombre, apellido, edad, fechaNac, rol, altura, peso, pais_origen, nombreCuadro, nombreSeleccion, tipo);
                                                devolver = "ok";
                                            }
                                            else
                                            {
                                                devolver = "Un jugador individual solo puede ser creado en (Tenis, PingPong, Boxeo)";
                                            }
                                        }
                                        else
                                        {
                                            a.crearJugador(nombre, apellido, edad, fechaNac, rol, altura, peso, pais_origen, nombreCuadro, nombreSeleccion, tipo);
                                            devolver = "ok";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }               
            }
            return devolver;
        }

        public DataTable buscarJugador(string nombre, string apellido, DataTable tabla)
        {
            AfySQL a = new AfySQL(); 
            tabla = a.consultarJugadorIndividual(nombre, apellido, tabla);
            return tabla;
        }

        public DataTable consultarJugadoresEquipos(string nombreCuadro, string rol, DataTable tabla)
        {
            AfySQL a = new AfySQL();
            if(string.IsNullOrEmpty(nombreCuadro) || string.IsNullOrEmpty(rol))
            {
                return null;
            } else
            {
                tabla = a.consultarJugadoresEquipos(nombreCuadro, rol, tabla);
                return tabla;
            }
        }

        public DataTable equiposDeLigas(string nombreLiga, DataTable tabla)
        {
            AfySQL a = new AfySQL();
            tabla = a.equiposDeLigas(nombreLiga, tabla);
            return tabla;
        }

        public DataTable seleccionesConDisciplinas(string disciplina, DataTable tabla)
        {
            AfySQL a = new AfySQL();
            tabla = a.seleccionesConDisciplina(disciplina, tabla);
            return tabla;
        }

        public DataTable mostrarJugadoresSeleccion(string seleccion, string disciplina, DataTable tabla)
        {
            AfySQL a = new AfySQL();
            if(string.IsNullOrEmpty(seleccion) || string.IsNullOrEmpty(disciplina))
            {
                return null;
            } else
            {
                tabla = a.mostrarJugadoresSeleccion(tabla, seleccion, disciplina);
                return tabla;
            }
        }

        public DataTable eliminarJugador(string nombre, string apellido, string rol, DataTable tabla)
        {
            AfySQL a = new AfySQL();
            tabla = a.eliminarJugador(nombre, apellido, rol, tabla);
            return tabla;            
        }

        public string borrarIdJugador(int idJugador, string nombre, string apellido)
        {
            AfySQL a = new AfySQL();
            string devolver = "";
            if (string.IsNullOrWhiteSpace(Convert.ToString(idJugador)))
            {
                devolver = "Ingrese un ID";
            } else
            {
                if(a.idJugadorExiste(idJugador, nombre, apellido) == true)
                {
                    a.eliminarJugadorConId(idJugador);
                    devolver = "ok";
                } else
                {
                    devolver = "Los datos no coinciden.";
                }
            }
            return devolver;
        }

        public string eliminarSeleccion(int id, string nomSeleccion, string rol)
        {
            AfySQL a = new AfySQL();
            string devolver = "";
            if(string.IsNullOrEmpty(Convert.ToString(id)) || string.IsNullOrEmpty(nomSeleccion) || string.IsNullOrEmpty(rol))
            {
                devolver = "Complete todos los campos";
            } else
            {
                if(a.existeSeleccion(id, nomSeleccion, rol) == true)
                {
                    a.eliminarSeleccion(id, nomSeleccion, rol);
                    devolver = "ok";
                } else
                {
                    devolver = "el ID no corresponde a la seleccion";
                }
            }
            return devolver;
        }

        public string eliminarCuadro(int id, string disciplina, string nomCuadro, string nomLiga)
        {
            AfySQL a = new AfySQL();
            string devolver = "";
            if(string.IsNullOrEmpty(Convert.ToString(id)) || string.IsNullOrEmpty(disciplina) || string.IsNullOrEmpty(nomCuadro) || string.IsNullOrEmpty(nomLiga))
            {
                devolver = "Complete todos los campos";
            } else
            {
                if(a.datosCuadroCoinciden(id, disciplina, nomCuadro, nomLiga) == true)
                {
                    a.eliminarCuadro(id, disciplina, nomCuadro, nomLiga);
                    devolver = "ok";
                } else
                {
                    devolver = "Los datos no coinciden.";
                }
            }
            return devolver;
        }

        public void crearRegistroUsuarios()
        {
            MySqlConnection cone = AfyConexion.conexion();
            AfySQL a = new AfySQL();
            MySqlDataReader reader = a.crearRegistroUsuarios();
                        
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("Reporte usuarios.pdf", FileMode.Create));
            doc.Open();
            Paragraph title = new Paragraph();
            title.Add("Reporte de usuarios, Fecha: " + DateTime.Now.ToShortDateString());
            doc.Add(new Paragraph(""));
            doc.Add(title);
            doc.Add(new Paragraph(""));

            PdfPTable table = new PdfPTable(4);
            table.AddCell("Email");
            table.AddCell("Nickname");
            table.AddCell("Contrasenia");
            table.AddCell("Tipo");         

            while (reader.Read())
            {
                table.AddCell(reader.GetString("Email").ToString());
                table.AddCell(reader.GetString("Nickname").ToString());
                table.AddCell(reader.GetString("Contrasenia").ToString());
                table.AddCell(reader.GetString("Tipo").ToString());
            }

            doc.Add(table);
            doc.Close();
            cone.Close();            
        }

        public DataTable seleccionVisitante(string nomSeleccionLocal, string disciplina, DataTable tabla)
        {
            AfySQL a = new AfySQL();
            tabla = a.seleccionVisitante(nomSeleccionLocal, disciplina, tabla);
            return tabla;
        }

        public DataTable jugadoresInvidualLocal(string disciplina, DataTable deporte)
        {
            AfySQL a = new AfySQL();
            deporte = a.jugadoresInvidualLocal(disciplina, deporte);
            return deporte;
        }

        public string comprobarCredencialesJugador(string aux, string nombre, string apellido)
        {
            string devolver = "";
            AfySQL a = new AfySQL();
            if(string.IsNullOrEmpty(Convert.ToString(aux)) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                devolver = "Complete todos los campos";
            } else
            {
                int id = int.Parse(aux);
                if(a.comprobarCredencialesJugador(id, nombre, apellido) == true)
                {
                    devolver = "ok";
                } else
                {
                    devolver = "las credenciales no coinciden";
                }
            }
            return devolver;
        }

        public DataTable mostrarVisitantes(int id, string rol, DataTable tabla)
        {
            AfySQL a = new AfySQL();
            tabla = a.mostrarVisitantes(id, rol, tabla);
            return tabla;
        }

        public string crearEventoTablaAuxIndividual(int idEvento, int idLocal, int resultado_local, int idVisitante, int resultado_vis, string fecha, string deporte)
        {
            AfySQL a = new AfySQL();
            a.crearEventoTablaAuxIndividual(idEvento, idLocal, resultado_local, idVisitante, resultado_vis, fecha, deporte);
            return "";
        }

        public MySqlDataReader devolverDatosEventos(int id)
        {
            AfySQL a = new AfySQL();
            return a.devolverDatosEventos(id);
        }

        public MySqlDataReader devolverDatosEventosEquipos(int id)
        {
            AfySQL a = new AfySQL();
            return a.devolverDatosEventosEquipos(id);
        }

        public string obtenerNombreDeJugador(int id)
        {
            AfySQL a = new AfySQL();
            return a.obtenerNombreDeJugador(id);            
        }

        public string actualizarValorEvento(int idEvento, string localOvisitante, int valor)
        {
            AfySQL a = new AfySQL();
            a.actualizarValorEvento(idEvento, localOvisitante, valor);
            return "";
        }

        public string actualizarValorEventoEquipo(int idEvento, string localOvisitante, int valor)
        {
            AfySQL a = new AfySQL();
            a.actualizarValorEventoEquipos(idEvento, localOvisitante, valor);
            return "";
        }

        public string actualizarValorEventoEquipos(int idEvento, string localOvisitante, int valor)
        {
            AfySQL a = new AfySQL();
            a.actualizarValorEvento(idEvento, localOvisitante, valor);
            return "";
        }

        public bool hayEvento(int id)
        {
            AfySQL a = new AfySQL();
            bool resultado = false; 
            resultado = a.hayEvento(id);
            return resultado;
        }

        public bool hayEventoEquipos(int id)
        {
            AfySQL a = new AfySQL();
            bool resultado = false;
            resultado = a.hayEventoEquipos(id);
            return resultado;
        }

        public string crearEventoTablaAuxEquipos(int idEvento, string fecha, string nomSelLocal, string alineacion_local, int resultado_local, string nomSelVis, string alineacion_vis, int resultado_vis, string deporte)
        {
            AfySQL a = new AfySQL();
            a.crearEventoTablaAuxEquipos(idEvento, fecha, nomSelLocal, alineacion_local, resultado_local, nomSelVis, alineacion_vis, resultado_vis, deporte);
            return "";
        }

        public string crearEventoEquipos(string fecha, int idEquipo1_local, int resultado_local, int idEquipo2_visitante, int resultado_visitante, string deporte, int idBorrar)
        {
            AfySQL a = new AfySQL();
            a.crearEventoEquipos(fecha, idEquipo1_local, resultado_local, idEquipo2_visitante, resultado_visitante, deporte, idBorrar); 
            return "";           
        }

        public string crearEventoIndividual(string fecha, int idEquipo1_local, int resultado_local, int idEquipo2_visitante, int resultado_visitante, string deporte, int idBorrar)
        {
            AfySQL a = new AfySQL();
            a.crearEventoIndividual(fecha, idEquipo1_local, resultado_local, idEquipo2_visitante, resultado_visitante, deporte, idBorrar);
            return "";
        }

    }
}
