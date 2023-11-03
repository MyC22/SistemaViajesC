using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Buses
{
    internal class ModeloBuss
    {
        public SqlDataReader leerBuss()
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("Select * from Buss", con.Open());
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
