using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Objetos
{
    public class ModeloRuta
    {
        public List<Rutas> MostrarRutas()
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand command = new SqlCommand("MostrarRutas", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    List<Rutas> rutas = new List<Rutas>();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Rutas ruta = new Rutas
                            {
                                ID = (int)reader["ID"],
                                Nombre = reader["Nombre"].ToString(),
                                Demora = (TimeSpan)reader["Demora"],
                                Origen = reader["Origen"].ToString(),
                                Destino = reader["Destino"].ToString()
                            };
                            rutas.Add(ruta);
                        }
                    }

                    return rutas;
                }
            }
        }


        public List<Rutas> BuscarRuta(int id, string nombreRuta)
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand command = new SqlCommand("BuscarRuta", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@ID", id));
                    command.Parameters.Add(new SqlParameter("@NombreRuta", nombreRuta));

                    List<Rutas> rutas = new List<Rutas>();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Rutas ruta = new Rutas
                            {
                                ID = (int)reader["ID"],
                                Nombre = reader["Nombre"].ToString(),
                                Origen = reader["Origen"].ToString(),
                                Destino = reader["Destino"].ToString(),
                                Demora = (TimeSpan)reader["Demora"]
                            };
                            rutas.Add(ruta);
                        }
                    }

                    return rutas;
                }
            }
        }

        public void EliminarRutaPorID(int rutaID)
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand command = new SqlCommand("EliminarRutaPorID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@RutaID", rutaID));

                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditarRuta(int rutaID, int idOrigen, int idDestino, string nombreRuta, TimeSpan demora)
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand command = new SqlCommand("EditarRuta", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@RutaID", rutaID));
                    command.Parameters.Add(new SqlParameter("@IDOrigen", idOrigen));
                    command.Parameters.Add(new SqlParameter("@IDDestino", idDestino));
                    command.Parameters.Add(new SqlParameter("@NombreRuta", nombreRuta));
                    command.Parameters.Add(new SqlParameter("@Demora", demora));

                    command.ExecuteNonQuery();
                }
            }
        }

        public void AgregarRuta(int idOrigen, int idDestino, string nombreRuta, TimeSpan demora)
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand command = new SqlCommand("AgregarRuta", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@IDOrigen", idOrigen));
                    command.Parameters.Add(new SqlParameter("@IDDestino", idDestino));
                    command.Parameters.Add(new SqlParameter("@NombreRuta", nombreRuta));
                    command.Parameters.Add(new SqlParameter("@Demora", demora));

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

