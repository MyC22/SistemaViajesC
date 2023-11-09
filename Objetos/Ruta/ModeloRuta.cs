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

        public void EditarRuta(Rutas r)
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand command = new SqlCommand("EditarRuta", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@RutaID", r.ID));
                    command.Parameters.Add(new SqlParameter("@IDOrigen", r.IDOrigen));
                    command.Parameters.Add(new SqlParameter("@IDDestino", r.IDDestino));
                    command.Parameters.Add(new SqlParameter("@NombreRuta", r.Nombre));
                    command.Parameters.Add(new SqlParameter("@Demora", r.Demora));

                    command.ExecuteNonQuery();
                }
            }
        }
        public DataTable listarlugar()
        {
            Conexion con = new Conexion();
            DataTable dt = new DataTable();
            SqlDataAdapter cmd = new SqlDataAdapter("select ID,Departamento,Distrito,Terminal from Lugar where Estado = 'Activo'", con.Open());
            cmd.Fill(dt);
            con.Close();
            return dt;
        }
        public void AgregarRuta(Rutas r)
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand command = new SqlCommand("AgregarRuta", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@IDOrigen", r.IDOrigen));
                    command.Parameters.Add(new SqlParameter("@IDDestino", r.IDDestino));
                    command.Parameters.Add(new SqlParameter("@NombreRuta", r.Nombre));
                    command.Parameters.Add(new SqlParameter("@Demora", r.Demora));

                    command.ExecuteNonQuery();
                }
            }
        }
        public SqlDataReader listarRutaID(int id)
        {
            Conexion conexion = new Conexion();
            SqlCommand cmd = new SqlCommand("select * from Ruta where ID = @id", conexion.Open());
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
    }
}

