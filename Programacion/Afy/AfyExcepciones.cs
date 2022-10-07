using System;
using System.Collections.Generic;
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
                                    afye.enviarMailRegistro(usuario.Email, usuario.Usuario); //Envio email.
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
                                afye.enviarMailSuscripcion(emailUsuario, nombreUsuario);
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
        } //Control para crear suscripcion

        public string eliminarControl(string Email, string usuario)
        {
            AfySQL afy = new AfySQL();
            string emailAuxiliar = Email;
            bool emailCorrecto = IsValidEmail(emailAuxiliar);
            string respuesta = "";
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(usuario))
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
                                } else
                                {
                                    respuesta = "Error";
                                }
                            } else
                            {
                                int aux = afy.EliminarUsuario(emailBien, usuario);
                                if (aux == 0)
                                {
                                    respuesta = "ok";
                                } else
                                {
                                    respuesta = "Error";
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            respuesta = ex.ToString();
                        }
                    } else
                    {
                        respuesta = "El email o usuario no existe.";
                    }
                }
            }
            return respuesta;
        }  //Control para eliminar usuarios

        public string nuevoAdmin(string email, string usuario)
        {
            AfySQL afy = new AfySQL();
            string resultado = "";
            string emailAux = email;
            bool emailCorrecto = IsValidEmail(emailAux);
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(usuario))
            {
                resultado = "Complete todos los espacios";
            } else
            {
                if (emailCorrecto != true)
                {
                    resultado = "El formato de email es incorrecto";
                } else
                {
                    bool usuarioExiste = afy.usuarioExiste(usuario);
                    bool mailExiste = afy.mailExiste(email);
                    if (usuarioExiste != true)
                    {
                        resultado = "El usuario no existe.";
                    } else
                    {
                        if (mailExiste != true)
                        {
                            resultado = "El email no existe.";
                        } else
                        {
                            try
                            {
                                int aux = afy.crearNuevoAdmin(email, usuario);
                                if (aux == 0)
                                {
                                    resultado = "ok";
                                } else
                                {
                                    resultado = "Error";
                                }
                            } catch (Exception ex)
                            {
                                resultado = ex.ToString();
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
                        afy.enviarMailRecuperacion(email);
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
                if(imagen == null)
                {
                    resultado = "Agregue una imagen porfavor.";
                } else
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

        public string eliminarPublicidad(int idPublicidad)
        {
            string resultado = "";
            AfySQL a = new AfySQL();

            if (string.IsNullOrEmpty(Convert.ToString(idPublicidad)))
            {
                resultado = "Ingrese un numero de publicidad";
            } else
            {
                bool respuesta = a.eliminarPublicidad(idPublicidad);
                if(respuesta == false)
                {
                    resultado = "ok";
                } else
                {
                    resultado = "el número de imagen no existe.";
                }
            }           
            return resultado;
        }
    }
}
