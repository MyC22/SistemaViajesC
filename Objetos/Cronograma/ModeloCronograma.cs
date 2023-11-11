using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Cronograma
{
    public class ModeloCronograma
    {
        public List<cronogramalista> Mostrarcronograma()
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("MostrarCronograma",con.Open());
            cmd.CommandType = CommandType.StoredProcedure;
            List<cronogramalista> cl = new List<cronogramalista>();
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                cronogramalista c = new cronogramalista
                {
                    id = (int)dr["ID"],
                    Ruta = dr["Ruta"].ToString(),
                    origen = dr["Origen"].ToString(),
                    destino = dr["Destino"].ToString(),
                    placabus = dr["Placa"].ToString(),
                    servicio = dr["Servicio"].ToString(),
                    preciop1 = (float)dr["Precio_piso1"],
                    preciop2 = (float)dr["Precio_piso2"],
                    fecha = (DateTime)dr["Fecha_salida"]
                };
                cl.Add(c);

            }
            return cl;
        }
        public void Agregarcronograma(Servicios s, cronograma c)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("Agregarcronograma", con.Open());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idruta", c.idruta);
            cmd.Parameters.AddWithValue("@placa", c.placabus);
            cmd.Parameters.AddWithValue("@fecha", c.fechasalida);
            cmd.Parameters.AddWithValue("@nombre", s.nombre);
            cmd.Parameters.AddWithValue("@precio1", s.preciop1);
            cmd.Parameters.AddWithValue("@precio2", s.preciop2);
            cmd.Parameters.AddWithValue("@usuario", c.usuario);
            cmd.ExecuteNonQuery();
        }
        public SqlDataReader mostrarservicio(int idcronograma)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("Select id from Servicio where IDCronograma = @idcronograma;", con.Open());
            cmd.Parameters.AddWithValue("@idcronograma", idcronograma);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
