using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos.Conexion
{
    public class ConexionBD
    {
        private SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=CRUD_N_CAPAS;Integrated Security=True");

        public SqlConnection OpenConnection() 
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            return conn;
        }

        public SqlConnection CloseConnection()
        {
            if(conn.State == ConnectionState.Open) conn.Close(); 
            return conn;
        }
    }
}
