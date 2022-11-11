using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Afy
{
    public class AfyEnvioMail
    {

        public string enviarMailRegistro(string mail, string usuario)
        {
            try
            {
                const string afyMail = "afysoftware@hotmail.com";
                const string afypassword = "L&fwJKwH7I%#";
                SmtpClient envio = new SmtpClient("smtp-mail.outlook.com");
                envio.Port = 587;
                envio.DeliveryMethod = SmtpDeliveryMethod.Network;
                envio.UseDefaultCredentials = false;
                System.Net.NetworkCredential de = new System.Net.NetworkCredential(afyMail, afypassword);
                envio.EnableSsl = true;
                envio.Credentials = de;
                MailMessage mailEnvio = new MailMessage(afyMail, mail);
                mailEnvio.Subject = usuario + ", Bienvenido/a a AfySport";
                mailEnvio.Body = "<center><img src=https://lh3.googleusercontent.com/g1gsuM3ey_WJataVvc43QcUHdMWHncCF8Tby2tSJtUAOdeYcv4KkbCGisocdvwbyLElbaEF2WGhey6wPgxSx3vFV87O8ZLR8KLHUYdhokRwLQ_WKQmEav4q7Dibp4oQN6X0oBTkFYbXCprI15kBgsuVoegmBvW64er5cJBuBfMyoAVlTfO56xoIFwo5Ae7TZTW1M_WBFeqCykkQ9htioSUHmXez2ronXbDL5M-sxrUKD0AXVZbsfbE0VWWfsKK6Gyg7aIDbfdlgQ7_PRSuHQTVbSKA9Tkzo9n1VmdqY5qcIpoC7IhB5AZPntKOosSjyvYpFrdSbbrsaDgMYYM0KeWRyjwbmoSFs4kxxTwF_IoBwMUMFUrIws7b4tcRZMGBZJUCUIg_e9zKXvOTEIapmFwNZXyCL531uZvXYgbAnjuYpwbNX3uNHMGArUtYat-rEraTWq15XaSrcw-0h1ys3LvcQABdlHFgKV8JOSssUWMGv-7yp-220PK4KKuHOI_HjpJtmYesSWcPahSJxLpd_pzCzYWbCj9r85mvhpKN-FOWqqAZQ3rKfKxoeHquhj_K7852_GtCp4KVa9DLkZSV9TdU4IXJQmvIBs5hFIdghJFrbXfW4ZIo_RaZs8D3ijm3bzSzcc-0oquRULJVw6W0Xh2x24BvIZWcpXsUSo_aIR3VCAZuQg565V4voHPfQ7Gy7N-1GlIoYVyj3s7L_du9Nf6skmDFnaAiEI6xxwbd8ng7W57dWyLoelmP_Q8-Z_vvgrBM_V6GnELCTqSovU_ES7Xkt7hdZpN3F0zY4-G98ujbGyYhbhtuiasSpSQ6rlDFUYY-OjVYQXv8JKubckCXwb8d5BBtHTZUFf8OVRZohNzJXhuIrsz-fziaJjYVdaVRQkfuiMxrRftc_FFytRgRgJOFoasrlyJP1aLbzEbtCkF4DNgkTuD5-RYs3VRYir4e_GJS9Ont-00Q=w497-h352-no?authuser=0 height=512px></center><h1>Registro creado exitosamente</h1><br><p>Le damos una cálida bienvenida.<p>\n<footer><br><br>Correo generado automáticamente " + DateTime.Now + " no responda este correo porque su respuesta no será leída.</footer>";
                mailEnvio.IsBodyHtml = true;
                envio.Send(mailEnvio); //Envio mail.
            }catch (SmtpException ex)
            {
                return ex.ToString();
            }
            return "";
        }

        public string enviarMailSuscripcion(string mail, string usuario)
        {
            try
            {
                DateTime fechaVe = DateTime.Today.AddMonths(1);
                const string afyMail = "afysoftware@hotmail.com";
                const string afypassword = "L&fwJKwH7I%#";
                SmtpClient envio = new SmtpClient("smtp-mail.outlook.com");
                envio.Port = 587;
                envio.DeliveryMethod = SmtpDeliveryMethod.Network;
                envio.UseDefaultCredentials = false;
                System.Net.NetworkCredential de = new System.Net.NetworkCredential(afyMail, afypassword);
                envio.EnableSsl = true;
                envio.Credentials = de;
                MailMessage mailEnvio = new MailMessage(afyMail, mail);
                mailEnvio.Subject = usuario + ", tú suscripción se realizó con éxito.";
                mailEnvio.Body = "<h1>Hola "+usuario+" !,<br></h1><h3><br>¡Muchas gracias por confiar en nosotros!</h3><p>.<p>\n<footer><br>Su suscripción se encuentra <b><font color=green>ACTIVA</font></b> hasta el día "+fechaVe+ " . <br><br>Correo generado automáticamente. No responder, ante cualquier duda o sugerencia, mail de contacto: afysrl@gmail.com</footer>";
                mailEnvio.IsBodyHtml = true;
                envio.Send(mailEnvio); //Envio mail.
            }
            catch (SmtpException ex)
            {
                return ex.ToString();
            }
            return "";
        }

        public string enviarMailrecuperacion(string mail, string usuario, string contrasenia)
        {
            try
            {
                const string afyMail = "afysoftware@hotmail.com";
                const string afypassword = "L&fwJKwH7I%#";
                SmtpClient envio = new SmtpClient("smtp-mail.outlook.com");
                envio.Port = 587;
                envio.DeliveryMethod = SmtpDeliveryMethod.Network;
                envio.UseDefaultCredentials = false;
                System.Net.NetworkCredential de = new System.Net.NetworkCredential(afyMail, afypassword);
                envio.EnableSsl = true;
                envio.Credentials = de;
                MailMessage mailEnvio = new MailMessage(afyMail, mail);
                mailEnvio.Subject = "Recuperar credenciales AfySport";
                mailEnvio.Body = "<center><h1>Sentimos que haya olvidado sus credenciales.</h1></center><br><br><h2>Credenciales para el Email: "+mail+"</h2><br><p>Usuario: "+usuario+"<br>Contraseña: "+contrasenia+"</p><footer><br><br>Correo generado automáticamente, no responda este correo porque su respuesta no será leída.</footer>";
                mailEnvio.IsBodyHtml = true;
                envio.Send(mailEnvio); //Envio mail.
            }
            catch (SmtpException ex)
            {
                return ex.ToString();
            }
            return "";
        }
    }
}
