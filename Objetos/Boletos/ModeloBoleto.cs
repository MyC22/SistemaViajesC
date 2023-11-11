using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class ModeloBoleto
    {
        public SqlDataReader listarservicio(int id)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("Select * from Servicio where id=@id;", con.Open());
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
