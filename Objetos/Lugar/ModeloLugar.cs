using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Objetos
{
    public class ModeloLugar
    {

        public List<Lugarr> BuscarLugares(int? id, string distrito, string departamento)
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand cmd = new SqlCommand("BuscarLugar", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = (object)id ?? DBNull.Value;
                    cmd.Parameters.Add("@Distrito", SqlDbType.VarChar, 50).Value = string.IsNullOrEmpty(distrito) ? (object)DBNull.Value : distrito;
                    cmd.Parameters.Add("@Departamento", SqlDbType.VarChar, 50).Value = string.IsNullOrEmpty(departamento) ? (object)DBNull.Value : departamento;

                    List<Lugarr> lugares = new List<Lugarr>();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Lugarr lugar = new Lugarr();
                            {
                                lugar.ID = Convert.ToInt32(reader["ID"]);
                                lugar.Distrito = reader["Distrito"].ToString();
                                lugar.Direccion = reader["Direccion"].ToString();
                                lugar.Terminal = reader["Terminal"].ToString();
                                lugar.Departamento = reader["Departamento"].ToString();
                                lugar.Estado = reader["Estado"].ToString();
                            };
                            lugares.Add(lugar);
                        }
                    }

                    return lugares;
                }
            }
        }
        
        public List<Lugarr> MostrarTodosLosLugares()
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand cmd = new SqlCommand("MostrarTodosLosLugares", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    List<Lugarr> lugares = new List<Lugarr>();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Lugarr lugar = new Lugarr();
                            {
                                lugar.ID = Convert.ToInt32(reader["ID"]);
                                lugar.Distrito = reader["Distrito"].ToString();
                                lugar.Direccion = reader["Direccion"].ToString();
                                lugar.Terminal = reader["Terminal"].ToString();
                                lugar.Departamento = reader["Departamento"].ToString();
                                lugar.Estado = reader["Estado"].ToString();
                            };
                            lugares.Add(lugar);
                        }
                    }

                    return lugares;
                }
            }
        }

        public void AgregarLugar(string distrito, string direccion, string terminal, string departamento, string estado)
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand cmd = new SqlCommand("AgregarLugar", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Distrito", SqlDbType.VarChar, 50).Value = distrito;
                    cmd.Parameters.Add("@Direccion", SqlDbType.VarChar, 100).Value = direccion;
                    cmd.Parameters.Add("@Terminal", SqlDbType.VarChar, 50).Value = terminal;
                    cmd.Parameters.Add("@Departamento", SqlDbType.VarChar, 50).Value = departamento;
                    cmd.Parameters.Add("@Estado", SqlDbType.VarChar, 50).Value = estado;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditarLugar(int id, string distrito, string direccion, string terminal, string departamento, string estado)
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand cmd = new SqlCommand("EditarLugar", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@Distrito", SqlDbType.VarChar, 50).Value = distrito;
                    cmd.Parameters.Add("@Direccion", SqlDbType.VarChar, 100).Value = direccion;
                    cmd.Parameters.Add("@Terminal", SqlDbType.VarChar, 50).Value = terminal;
                    cmd.Parameters.Add("@Departamento", SqlDbType.VarChar, 50).Value = departamento;
                    cmd.Parameters.Add("@Estado", SqlDbType.VarChar, 50).Value = estado;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarLugar(int id)
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand cmd = new SqlCommand("EliminarLugar", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}