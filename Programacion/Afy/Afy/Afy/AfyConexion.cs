using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Afy
{
    class AfyConexion
    {
        public static MySqlConnection conexion()
        {
            string conexion = "server= 127.0.0.1; Database = proyecto; User Id = root; password = root";
            try
            {
                MySqlConnection cone = new MySqlConnection(conexion);

                return cone;
            }catch(MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

    }
}
