using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Objetos
{
    public class Conexion
    {
        private SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=sistemaviajes;Integrated Security=True");

        public SqlConnection Open() 
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            return conn;
        }

        public SqlConnection Close()
        {
            if(conn.State == ConnectionState.Open) conn.Close(); 
            return conn;
        }
    }
}
