using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class modelocomprobante
    {
        public int agregarfactura(comprobante c)
        {
            int id = 0;
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("agregarcomprovante", con.Open());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcliente", c.idcliente);
            cmd.Parameters.AddWithValue("@fecha", c.fecha);
            cmd.Parameters.AddWithValue("@igv", c.igv);
            cmd.Parameters.AddWithValue("@precio", c.precio);
            cmd.Parameters.AddWithValue("@preciot", c.precioT);
            cmd.Parameters.AddWithValue("@tipo", c.tipocomporbante);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                id = (int)dr["id"];
            }
            return id;
        }
    }
}
