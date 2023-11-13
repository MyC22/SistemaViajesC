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
        //Agregar Buss tiene como parametro las variables y el tipo 
        public void AgregarBuss(string Placa, int Modelo, string lugar, DateTime disponibilidad)
        {   //Se realiza la conexion para pasar los parametros y hacer uso del procedure
            Conexion conexio = new Conexion();
            using (SqlConnection connection = conexio.Open())
            {       //En esta parte hace uso del procedimiento AgregarBuss usando la conexion
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

        //Hace uso de una lista para mostrar todos los buses
        //tambien tiene un bucle para realizar el listado dependiendo cuantas filas tenga
        // Método para obtener y retornar una lista de todos los buses desde la base de datos
        public List<Buses> MostrarTodosBuses()
        {
            // Crear una instancia de la clase de conexión a la base de datos
            Conexion conexion = new Conexion();

            // Utilizar la instrucción 'using' para asegurar la liberación adecuada de los recursos

            using (SqlConnection connection = conexion.Open())
            {
                // Crear un nuevo comando SQL utilizando el nombre del procedimiento almacenado
                using (SqlCommand cmd = new SqlCommand("MostrarBuses", connection))
                {
                    // Especificar que el comando es de tipo procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Crear una lista para almacenar los objetos de tipo Buses
                    List<Buses> buses = new List<Buses>();

                    // Utilizar un lector de datos para obtener los resultados del procedimiento almacenado
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Iterar a través de las filas devueltas por el lector de datos
                        while (reader.Read())
                        {
                            // Crear una nueva instancia de la clase Buses
                            Buses bu = new Buses();
                            {
                                // Asignar valores a las propiedades del objeto Buses desde los resultados de la base de datos
                                bu.Placa = reader["Placa"].ToString();
                                bu.IdModelo = Convert.ToInt32(reader["IdModelo"]);
                                bu.Lugar = reader["Lugar"].ToString();
                                bu.Disponibilidad = Convert.ToDateTime(reader["Disponible"]);
                            };

                            // Agregar el objeto Buses a la lista de buses
                            buses.Add(bu);
                        }
                    }

                    // Retornar la lista de buses
                    return buses;
                }
            }
        }


    }
}
