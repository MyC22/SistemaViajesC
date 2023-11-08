using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Cargo
{
    public class ModeloCargo
    {
        public DataTable listarCargo()
        {
            Conexion con = new Conexion();
            DataTable dt = new DataTable();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Cargo", con.Open());
            cmd.Fill(dt);
            con.Close();
            return dt;
        }

        public void guardarCargo(Cargo c) 
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("guardarCargo", con.Open());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cargo", c.nombre);
            cmd.Parameters.AddWithValue("@Descripcion", c.descripcion);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
    }
}
