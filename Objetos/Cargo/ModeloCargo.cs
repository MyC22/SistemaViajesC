using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Cargo
{
    public class ModeloCargo
    {
        public List<Cargo> BuscarCargo(int? id, string nombre, string descripcion)
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand cmd = new SqlCommand("BuscarCargo", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = (object)id ?? DBNull.Value;
                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = string.IsNullOrEmpty(nombre) ? (object)DBNull.Value : nombre;
                    cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = string.IsNullOrEmpty(descripcion) ? (object)DBNull.Value : descripcion;
                    
                    List<Cargo> Cargos = new List<Cargo>();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cargo cargo = new Cargo();
                            {
                                cargo.ID = Convert.ToInt32(reader["ID"]);
                                cargo.nombre = reader["Modelo"].ToString();
                                cargo.descripcion = reader["Tamanio"].ToString();
                            };
                            Cargos.Add(cargo);
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
                using (SqlCommand cmd = new SqlCommand("MostrarTodosLosModelos", connection))
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
                                cargo.nombre = reader["Nombre"].ToString();
                                cargo.descripcion = reader["Descripcion"].ToString();
                            };
                            Cargos.Add(cargo);
                        }
                    }
                    return Cargos;
                }
            }
        }

        public void AgregarCargo(string nombre, string descripcion)
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand cmd = new SqlCommand("AgregarCargo", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = nombre;
                    cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 100).Value = descripcion;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditaCargo(int id, string nombre, string descripcion)
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand cmd = new SqlCommand("EditarModelo", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = nombre;
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


        public void guardarCargo(Cargo c) 
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("guardarCargo", con.Open());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cargo", c.nombre);
            cmd.Parameters.AddWithValue("@Descripcion", c.descripcion);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
    }
}
