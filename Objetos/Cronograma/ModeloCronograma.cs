using System;
using System.Collections.Generic;
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
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
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
                    preciop1 = (double)dr["Precio_piso1"],
                    preciop2 = (double)dr["Precio_piso2"],
                    fecha = (DateTime)dr["Fecha_salida"]
                };
                cl.Add(c);

            }
            return cl;
        }
    }
}
