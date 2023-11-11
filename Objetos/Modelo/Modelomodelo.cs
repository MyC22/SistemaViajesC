using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Modelo
{
    public class Modelomodelo
    {
        public List<Modelo> BuscarModelos(int? id, string nombre, string tamanio, int asientos)
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand cmd = new SqlCommand("BuscarModelo", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = (object)id ?? DBNull.Value;
                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = string.IsNullOrEmpty(nombre) ? (object)DBNull.Value : nombre;
                    cmd.Parameters.Add("@Tamanio", SqlDbType.VarChar, 50).Value = string.IsNullOrEmpty(tamanio) ? (object)DBNull.Value : tamanio;
                    cmd.Parameters.Add("@Asientos", SqlDbType.Int).Value = asientos != null ? asientos : (object)DBNull.Value;

                    List<Modelo> Modelos = new List<Modelo>();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Modelo modelo = new Modelo();
                            {
                                modelo.ID = Convert.ToInt32(reader["ID"]);
                                modelo.Nombre = reader["Modelo"].ToString();
                                modelo.Tamaño = reader["Tamaño"].ToString();
                                modelo.Asientos = Convert.ToInt32(reader["Asientos"]);
                                modelo.pisos = Convert.ToInt32(reader["pisos"]);
                            };
                            Modelos.Add(modelo);
                        }
                    }
                    return Modelos;
                }
            }
        }

        public List<Modelo> MostrarTodosLosModelos()
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand cmd = new SqlCommand("MostrarTodosLosModelos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    List<Modelo> modelos = new List<Modelo>();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Modelo modelo = new Modelo();
                            {
                                modelo.ID = Convert.ToInt32(reader["ID"]);
                                modelo.Nombre = reader["Modelo"].ToString(); 
                                modelo.Tamaño = reader["Tamaño"].ToString();
                                modelo.Asientos = Convert.ToInt32(reader["Asientos"]);
                                modelo.pisos = Convert.ToInt32(reader["pisos"]);
                            };
                            modelos.Add(modelo);
                        }
                    }

                    return modelos;
                }
            }
        }

        public void AgregarModelo(string nombre, string tamanio, int asientos, int pisos)
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand cmd = new SqlCommand("AgregarModelo", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = nombre;
                    cmd.Parameters.Add("@Tamanio", SqlDbType.VarChar, 100).Value = tamanio;
                    cmd.Parameters.Add("@Asientos", SqlDbType.Int, 20).Value = asientos;
                    cmd.Parameters.Add("@pisos", SqlDbType.Int).Value = pisos;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditaModelo(int id, string nombre, string tamanio, int asientos, int pisos)
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand cmd = new SqlCommand("EditarModelo", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@Nombre", SqlDbType.Char, 10).Value = nombre;
                    cmd.Parameters.Add("@Tamanio", SqlDbType.VarChar, 50).Value = tamanio;
                    cmd.Parameters.Add("@Asientos", SqlDbType.Int).Value = asientos;
                    cmd.Parameters.Add("@pisos", SqlDbType.Int).Value = pisos;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarModelo(int id)
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand cmd = new SqlCommand("EliminarModelo", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
