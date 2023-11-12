using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class ModeloCargo
    {
        public List<Cargo> BuscarCargo(int? id, string cargo, string descripcion)
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand cmd = new SqlCommand("BuscarCargo", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = (object)id ?? DBNull.Value;
                    cmd.Parameters.Add("@Cargo", SqlDbType.VarChar, 50).Value = string.IsNullOrEmpty(cargo) ? (object)DBNull.Value : cargo;
                    cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = string.IsNullOrEmpty(descripcion) ? (object)DBNull.Value : descripcion;
                    
                    List<Cargo> Cargos = new List<Cargo>();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cargo cargos = new Cargo();
                            {
                                cargos.ID = Convert.ToInt32(reader["ID"]);
                                cargos.cargo = reader["Modelo"].ToString();
                                cargos.descripcion = reader["Tamanio"].ToString();
                            };
                            Cargos.Add(cargos);
                        }
                    }
                    return Cargos;
                }
            }
        }

        public List<Cargo> MostrarTodosLosCargos()
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand cmd = new SqlCommand("MostrarTodosLosCargos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    List<Cargo> Cargos = new List<Cargo>();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cargo cargo = new Cargo();
                            {
                                cargo.ID = Convert.ToInt32(reader["ID"]);
                                cargo.cargo = reader["Cargo"].ToString();
                                cargo.descripcion = reader["Descripcion"].ToString();
                            };
                            Cargos.Add(cargo);
                        }
                    }
                    return Cargos;
                }
            }
        }

        public void AgregarCargo(string cargo, string descripcion)
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand cmd = new SqlCommand("AgregarCargo", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Cargo", SqlDbType.VarChar, 50).Value = cargo;
                    cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100).Value = descripcion;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditaCargo(int id, string cargo, string descripcion)
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand cmd = new SqlCommand("EditaCargo", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@Cargo", SqlDbType.VarChar, 50).Value = cargo;
                    cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100).Value = descripcion;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarCargo(int id)
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand cmd = new SqlCommand("EliminarCargo", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
