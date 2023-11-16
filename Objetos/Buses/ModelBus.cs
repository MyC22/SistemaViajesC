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
        public void AgregarBuss(Buses b)
        {   //Se realiza la conexion para pasar los parametros y hacer uso del procedure
            Conexion conexio = new Conexion();
            using (SqlConnection connection = conexio.Open())
            {       //En esta parte hace uso del procedimiento AgregarBuss usando la conexion
                using (SqlCommand cmd = new SqlCommand("AgregarBuss", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Placa", SqlDbType.Char, 6).Value = b.Placa;
                    cmd.Parameters.Add("@IdModelo", SqlDbType.Int).Value = b.IdModelo;
                    cmd.Parameters.Add("@Lugar", SqlDbType.VarChar, 50).Value = b.Lugar;
                    cmd.Parameters.AddWithValue("@Disponible", b.Disponibilidad);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public SqlDataReader listarbusid(string placa)
        {
            Conexion conexio = new Conexion();
            SqlCommand cmd = new SqlCommand("select * from Buses where Placa = @placa;", conexio.Open());
            cmd.Parameters.AddWithValue("@placa", placa);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public void EditarBuss(Buses b)
        {
            Conexion conexio = new Conexion();
            using (SqlConnection connection = conexio.Open())
            {
                using (SqlCommand cmd = new SqlCommand("editarBus", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Placa", SqlDbType.Char, 6).Value = b.Placa;
                    cmd.Parameters.Add("@IdModelo", SqlDbType.Int).Value = b.IdModelo;
                    cmd.Parameters.Add("@Lugar", SqlDbType.VarChar, 50).Value = b.Lugar;
                    cmd.Parameters.AddWithValue("@Disponible", b.Disponibilidad);
                    cmd.ExecuteNonQuery();
                }
            }


        }

        //Hace uso de una lista para mostrar todos los buses
        //tambien tiene un bucle para realizar el listado dependiendo cuantas filas tenga
        // Método para obtener y retornar una lista de todos los buses desde la base de datos
        public List<listabuses> MostrarTodosBuses()
        {
            // Crear una instancia de la clase de conexión a la base de datos
            Conexion conexion = new Conexion();

            // Utilizar la instrucción 'using' para asegurar la liberación adecuada de los recursos

            using (SqlConnection connection = conexion.Open())
            {
                // Crear un nuevo comando SQL utilizando el nombre del procedimiento almacenado
                using (SqlCommand cmd = new SqlCommand("select b.Placa,m.Modelo,b.Lugar,b.Disponible from Buses as b inner join ModeloBus as m on b.IdModelo = m.ID", connection))
                {
                    // Crear una lista para almacenar los objetos de tipo Buses
                    List<listabuses> buses = new List<listabuses>();

                    // Utilizar un lector de datos para obtener los resultados del procedimiento almacenado
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Iterar a través de las filas devueltas por el lector de datos
                        while (reader.Read())
                        {
                            // Crear una nueva instancia de la clase Buses
                            listabuses bu = new listabuses();
                            {
                                // Asignar valores a las propiedades del objeto Buses desde los resultados de la base de datos
                                bu.Placa = reader["Placa"].ToString();
                                bu.modelo = reader["Modelo"].ToString();
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
        public void EliminarBuss(string placa)
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand cmd = new SqlCommand("EliminarBuss", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Placa", SqlDbType.Char,6).Value = placa;

                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}
