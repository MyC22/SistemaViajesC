﻿using System;
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
            cmd.Parameters.AddWithValue("@disponible", c.fechasalida + TimeSpan.Parse("3:00") );
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
        public int mostrarasientosdiponibles(int id)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("mostrarasientosdiponibles", con.Open());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                return (int)dr["asientos"];
            }else { return 0; }
        }
        public int mostraridcronograma(int id)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("select c.ID from Cronograma_viajes as c inner join Servicio as s on c.ID = s.IDCronograma where s.ID=@id", con.Open());
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return (int)dr["ID"];
            }
            else { return 0; }
        }
        public DataTable mostrarbusesdisponible(int idruta, DateTime fecha)
        {
            Conexion con = new Conexion();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("mostrarbusesdisponible", con.Open());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idruta", idruta);
            cmd.Parameters.AddWithValue("@fecha", fecha);
            SqlDataAdapter cmdd = new SqlDataAdapter(cmd);
            cmdd.Fill(dt);
            return dt;
        }
    }
}
