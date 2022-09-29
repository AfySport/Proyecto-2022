using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Afy
{
    class AfyConsultaSQL
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
            } else if(emailCorrecto == true) 
            {
                if(usuario.Contrasenia == usuario.ConfirmarContrasenia)
                {
                    if (afyi.usuarioExiste(usuario.Usuario)) //Comprobar si ya existe un usuario con el nombre.
                    {
                        resultado = "El usuario ya existe.";
                    } else
                    {
                        usuario.Tipo = "U-NoSuscrito";
                        afyi.registrar(usuario); //Creo el usuario y lo agrego a la DB
                        afyregistro afyr = new afyregistro();
                        afyr.borrar();
                        const string afyMail = "afysoftware@hotmail.com";
                        const string afypassword = "L&fwJKwH7I%#";
                        SmtpClient envio = new SmtpClient("smtp-mail.outlook.com");
                        envio.Port = 587;
                        envio.DeliveryMethod = SmtpDeliveryMethod.Network;
                        envio.UseDefaultCredentials = false;
                        System.Net.NetworkCredential de = new System.Net.NetworkCredential(afyMail, afypassword);
                        envio.EnableSsl = true;
                        envio.Credentials = de;
                        MailMessage mailEnvio = new MailMessage(afyMail, emailEnvio);
                        mailEnvio.Subject = usuario.Usuario + ", Bienvenido/a a AfySport";
                        mailEnvio.Body = "<center><img src=https://lh3.googleusercontent.com/edlEOsssGE9Sf88bHSuYv55l66mNyIDC8XkpA1gZXi4SbcorYB1CYJLs8KDWFfvRy9plypq7gMAyKSAVW2upEBtQW8p6rZohyWTozp46bnb5ZyDHkGH1U5K-JVxyNiorUTulE1UwJUSfkcK55RhEeZ3KCQXxBkdiNHJUDDF32oI_aaYwUAzU0ceudDXESO9Fu0OFjLYrzyfYbgoveuqXj79bHnF8baqIA5ok7a4OY82Ec6dcjVjd77klcAj3VYMq7Kakj0D2zV4Ab4oJm0Nmh1fdl0Nv1CQ1KgU4XRu8S6Y7gd9Te2WNxxJ6JswkND17nmlHZWHSS50P4X-ImSEdBbVZGQQk5ICmPRezDZ3EEURYkm9bBtMn3lKZF7x5ASrUyr04kahCG3YtIZ2lpCeEZtq1aI254Pu3vBsn7Z_ZPHN-tff8akwaK8-NaRyi-W8UFeoUxImilGwHpgccn4kGytJ_CQRtqRcDiUh5_s3l0vZFDK6uIHaTXrrTtJ5x_Z4h8t5cqWTpJdRC7C55P9U-m1-jxWrshbnQmghZWeBeGPgMtflSngCmJbaVM6HfcpBjmB46g-jtkSZEDA6HgaYaQ8hnTrhLNTzOuvVBRrUieMWZqqkSxsAwZE8-K0w1WzIEOah52F9wYy1ObnphDbZ5GQskVclYfAW86s4kHcSWNQRUsggDUjZK0qxjfm2FMcFbM97p2easAOGoeX-Hyrg1D4A-zKi5YdKVKVMARLqCDmxe6WHEWujyA5mTK77ebnYgaCvbVEZxY5bWytYrUqoAaLI3v7P7a7NJENqGO8qfW5XPdpyj3vzP8JitaNjIGg=w497-h352-no?authuser=0 height=512px></center><h1>Registro creado exitosamente</h1><br><p>Le damos una cálida bienvenida.<p>\n<footer><br><br>Correo generado automáticamente " + DateTime.Now + " no responda este correo porque su respuesta no será leída.</footer>";
                        mailEnvio.IsBodyHtml = true;
                        envio.Send(mailEnvio);
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

            if(string.IsNullOrEmpty(nickname) || string.IsNullOrEmpty(contrasenia))
            {
                resultado = "LLene todos los campos.";
            } else
            {
                usuarioLogin = afysql.login(nickname);

                if(usuarioLogin == null) //No existe el usuario.
                {
                    resultado = "El usuario no existe.";
                } else
                {
                    if(usuarioLogin.Contrasenia != contrasenia) //No coinciden.
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


    }
}
