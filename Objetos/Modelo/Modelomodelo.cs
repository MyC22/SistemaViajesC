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
            // Se establece una conexión a la base de datos utilizando la clase de conexión personalizada.
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                // Se utiliza un comando SQL almacenado llamado "BuscarModelo".
                using (SqlCommand cmd = new SqlCommand("BuscarModelo", connection))
                {
                    // Se especifica que el comando es de tipo procedimiento almacenado.
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Se asignan los parámetros del procedimiento almacenado con valores proporcionados o nulos según la necesidad.
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = (object)id ?? DBNull.Value;
                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = string.IsNullOrEmpty(nombre) ? (object)DBNull.Value : nombre;
                    cmd.Parameters.Add("@Tamanio", SqlDbType.VarChar, 50).Value = string.IsNullOrEmpty(tamanio) ? (object)DBNull.Value : tamanio;
                    cmd.Parameters.Add("@Asientos", SqlDbType.Int).Value = asientos != null ? asientos : (object)DBNull.Value;

                    // Se inicializa una lista para almacenar los modelos de autobuses encontrados.
                    List<Modelo> Modelos = new List<Modelo>();

                    // Se ejecuta el comando y se recorre el resultado utilizando un lector de datos.
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Se crea un objeto Modelo para cada registro encontrado y se llenan sus propiedades.
                            Modelo modelo = new Modelo();
                            {
                                modelo.ID = Convert.ToInt32(reader["ID"]);
                                modelo.Nombre = reader["Modelo"].ToString();
                                modelo.Tamaño = reader["Tamaño"].ToString();
                                modelo.Asientos = Convert.ToInt32(reader["Asientos"]);
                                modelo.pisos = Convert.ToInt32(reader["pisos"]);
                            };
                            // El modelo se agrega a la lista de modelos.
                            Modelos.Add(modelo);
                        }
                    }
                    // Se devuelve la lista de modelos encontrados.
                    return Modelos;
                }
            }
        }

        public List<Modelo> MostrarTodosLosModelos()
        {
            // Se establece una conexión a la base de datos utilizando la clase de conexión personalizada.
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                // Se utiliza un comando SQL almacenado llamado "MostrarTodosLosModelos".
                using (SqlCommand cmd = new SqlCommand("MostrarTodosLosModelos", connection))
                {
                    // Se especifica que el comando es de tipo procedimiento almacenado.
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Se inicializa una lista para almacenar todos los modelos de autobuses.
                    List<Modelo> modelos = new List<Modelo>();

                    // Se ejecuta el comando y se recorre el resultado utilizando un lector de datos.
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Se crea un objeto Modelo para cada registro encontrado y se llenan sus propiedades.
                            Modelo modelo = new Modelo();
                            {
                                modelo.ID = Convert.ToInt32(reader["ID"]);
                                modelo.Nombre = reader["Modelo"].ToString();
                                modelo.Tamaño = reader["Tamaño"].ToString();
                                modelo.Asientos = Convert.ToInt32(reader["Asientos"]);
                                modelo.pisos = Convert.ToInt32(reader["pisos"]);
                            };
                            // El modelo se agrega a la lista de modelos.
                            modelos.Add(modelo);
                        }
                    }

                    // Se devuelve la lista completa de modelos de autobuses.
                    return modelos;
                }
            }
        }

        public void AgregarModelo(string nombre, string tamanio, int asientos, int pisos)
        {
            // Se establece una conexión a la base de datos utilizando la clase de conexión personalizada.
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                // Se utiliza un comando SQL almacenado llamado "AgregarModelo".
                using (SqlCommand cmd = new SqlCommand("AgregarModelo", connection))
                {
                    // Se especifica que el comando es de tipo procedimiento almacenado.
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Se asignan los parámetros del procedimiento almacenado con los valores proporcionados.
                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = nombre;
                    cmd.Parameters.Add("@Tamanio", SqlDbType.VarChar, 100).Value = tamanio;
                    cmd.Parameters.Add("@Asientos", SqlDbType.Int, 20).Value = asientos;
                    cmd.Parameters.Add("@pisos", SqlDbType.Int).Value = pisos;

                    // Se ejecuta el comando para realizar la inserción en la base de datos.
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditaModelo(int id, string nombre, string tamanio, int asientos, int pisos)
        {
            // Se establece una conexión a la base de datos utilizando la clase de conexión personalizada.
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                // Se utiliza un comando SQL almacenado llamado "EditarModelo".
                using (SqlCommand cmd = new SqlCommand("EditarModelo", connection))
                {
                    // Se especifica que el comando es de tipo procedimiento almacenado.
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Se asignan los parámetros del procedimiento almacenado con los valores proporcionados.
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@Nombre", SqlDbType.Char, 10).Value = nombre;
                    cmd.Parameters.Add("@Tamanio", SqlDbType.VarChar, 50).Value = tamanio;
                    cmd.Parameters.Add("@Asientos", SqlDbType.Int).Value = asientos;
                    cmd.Parameters.Add("@pisos", SqlDbType.Int).Value = pisos;

                    // Se ejecuta el comando para realizar la actualización en la base de datos.
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarModelo(int id)
        {
            // Se establece una conexión a la base de datos utilizando la clase de conexión personalizada.
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                // Se utiliza un comando SQL almacenado llamado "EliminarModelo".
                using (SqlCommand cmd = new SqlCommand("EliminarModelo", connection))
                {
                    // Se especifica que el comando es de tipo procedimiento almacenado.
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Se asigna el parámetro del procedimiento almacenado con el valor proporcionado.
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;

                    // Se ejecuta el comando para realizar la eliminación en la base de datos.
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
