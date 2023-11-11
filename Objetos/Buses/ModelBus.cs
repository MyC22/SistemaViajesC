using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objetos.Buses;
namespace Objetos.Buses
{
    public class ModelBus
    {
        public void AgregarBuss(string Placa, int Modelo, string lugar, DateTime disponibilidad)
        {
            Conexion conexio = new Conexion();
            using (SqlConnection connection = conexio.Open())
            {
                using (SqlCommand cmd = new SqlCommand("AgregarBuss", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Placa", SqlDbType.Char, 6).Value = Placa;
                    cmd.Parameters.Add("@IdModelo", SqlDbType.Int).Value = Modelo;
                    cmd.Parameters.Add("@Lugar", SqlDbType.VarChar, 50).Value = lugar;
                    cmd.Parameters.Add("@Disponible", SqlDbType.DateTime).Value = disponibilidad;


                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void EditarBuss(string Placa, int Modelo, string lugar, DateTime disponibilidad)
        {
            Conexion conexio = new Conexion();
            using (SqlConnection connection = conexio.Open())
            {
                using (SqlCommand cmd = new SqlCommand("EditarLugar", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Placa", SqlDbType.Char, 6).Value = Placa;
                    cmd.Parameters.Add("@IdModelo", SqlDbType.Int).Value = Modelo;
                    cmd.Parameters.Add("@Lugar", SqlDbType.VarChar, 50).Value = lugar;
                    cmd.Parameters.Add("@Disponible", SqlDbType.DateTime).Value = disponibilidad;

                    cmd.ExecuteNonQuery();
                }
            }


        }
        public List<Buses> MostrarTodosBuses()
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand cmd = new SqlCommand("MostrarBuses", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    List<Buses> buses = new List<Buses>();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Buses bu = new Buses();
                            {
                                bu.Placa = reader["Placa"].ToString();
                                bu.IdModelo= Convert.ToInt32(reader["IdModelo"]);
                                bu.Lugar = reader["Lugar"].ToString();
                                bu.Disponibilidad = Convert.ToDateTime(reader["Disponible"]);
                                
                            };
                            buses.Add(bu);
                        }
                    }

                    return buses;
                }
            }
        }
    }
}
