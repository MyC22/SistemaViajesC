using System;
using System.Collections.Generic;
using System.Data;
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
        public int agregarpasajero(pasajero p)
        {
            int id = 0;
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("agregarpasajero", con.Open());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", p.nombre);
            cmd.Parameters.AddWithValue("@apellido", p.apellidos);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id = (int)dr["id"];
            }
            return id;
        }
        public void agregarboleto(boletos b)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("agregarboleto", con.Open());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcomprobante", b.idfactura);
            cmd.Parameters.AddWithValue("@idservicio", b.idservicio);
            cmd.Parameters.AddWithValue("@precio", b.precio);
            cmd.Parameters.AddWithValue("@idpasajero", b.idpasajero);
            cmd.ExecuteNonQuery();
        }
    }
}
