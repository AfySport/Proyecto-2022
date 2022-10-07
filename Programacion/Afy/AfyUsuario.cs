using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Afy
{
    class AfyUsuario
    {
        string email, usuario, contrasenia, confirmarContrasenia, tipo;
        DateTime fechaRegistro;

        public DateTime FechaRegistro { get; set; }

        public string Email { get; set; }

        public string Usuario { get; set; }

        public string Contrasenia { get; set; }

        public string ConfirmarContrasenia { get; set; }

        public string Tipo { get; set; }
    }
}
