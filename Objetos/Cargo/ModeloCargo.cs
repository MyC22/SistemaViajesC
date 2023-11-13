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
    // Se establece una conexión a la base de datos utilizando la clase de conexión personalizada.
    Conexion conexion = new Conexion();
    using (SqlConnection connection = conexion.Open())
    {
        // Se utiliza un comando SQL almacenado llamado "BuscarCargo".
        using (SqlCommand cmd = new SqlCommand("BuscarCargo", connection))
        {
            // Se especifica que el comando es de tipo procedimiento almacenado.
            cmd.CommandType = CommandType.StoredProcedure;

            // Se asignan los parámetros del procedimiento almacenado con los valores proporcionados.
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = (object)id ?? DBNull.Value;
            cmd.Parameters.Add("@Cargo", SqlDbType.VarChar, 50).Value = string.IsNullOrEmpty(cargo) ? (object)DBNull.Value : cargo;
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = string.IsNullOrEmpty(descripcion) ? (object)DBNull.Value : descripcion;

            // Se crea una lista para almacenar los resultados de la búsqueda.
            List<Cargo> Cargos = new List<Cargo>();

            // Se ejecuta el comando y se lee el resultado utilizando un lector de datos.
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Se crea un objeto Cargo para cada registro devuelto por la base de datos.
                    Cargo cargos = new Cargo();
                    {
                        cargos.ID = Convert.ToInt32(reader["ID"]);
                        cargos.cargo = reader["Cargo"].ToString();
                        cargos.descripcion = reader["Descripcion"].ToString();
                    };
                    // Se añade el objeto Cargo a la lista de resultados.
                    Cargos.Add(cargos);
                }
            }
            // Se devuelve la lista de Cargos que cumplen con los criterios de búsqueda.
            return Cargos;
        }
    }
}

        public List<Cargo> MostrarTodosLosCargos()
        {
            // Se establece una conexión a la base de datos utilizando la clase de conexión personalizada.
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                // Se utiliza un comando SQL almacenado llamado "MostrarTodosLosCargos".
                using (SqlCommand cmd = new SqlCommand("MostrarTodosLosCargos", connection))
                {
                    // Se especifica que el comando es de tipo procedimiento almacenado.
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Se crea una lista para almacenar todos los cargos disponibles.
                    List<Cargo> Cargos = new List<Cargo>();

                    // Se ejecuta el comando y se lee el resultado utilizando un lector de datos.
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Se crea un objeto Cargo para cada registro devuelto por la base de datos.
                            Cargo cargo = new Cargo();
                            {
                                cargo.ID = Convert.ToInt32(reader["ID"]);
                                cargo.cargo = reader["Cargo"].ToString();
                                cargo.descripcion = reader["Descripcion"].ToString();
                            };
                            // Se añade el objeto Cargo a la lista de resultados.
                            Cargos.Add(cargo);
                        }
                    }
                    // Se devuelve la lista de todos los cargos disponibles en la base de datos.
                    return Cargos;
                }
            }
        }

        public void AgregarCargo(string cargo, string descripcion)
        {
            // Se establece una conexión a la base de datos utilizando la clase de conexión personalizada.
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                // Se utiliza un comando SQL almacenado llamado "AgregarCargo".
                using (SqlCommand cmd = new SqlCommand("AgregarCargo", connection))
                {
                    // Se especifica que el comando es de tipo procedimiento almacenado.
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Se asignan los parámetros del procedimiento almacenado con los valores proporcionados.
                    cmd.Parameters.Add("@Cargo", SqlDbType.VarChar, 50).Value = cargo;
                    cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100).Value = descripcion;

                    // Se ejecuta el comando para agregar el nuevo cargo a la base de datos.
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditaCargo(int id, string cargo, string descripcion)
        {
            // Se establece una conexión a la base de datos utilizando la clase de conexión personalizada.
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                // Se utiliza un comando SQL almacenado llamado "EditaCargo".
                using (SqlCommand cmd = new SqlCommand("EditaCargo", connection))
                {
                    // Se especifica que el comando es de tipo procedimiento almacenado.
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Se asignan los parámetros del procedimiento almacenado con los valores proporcionados.
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@Cargo", SqlDbType.VarChar, 50).Value = cargo;
                    cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100).Value = descripcion;

                    // Se ejecuta el comando para editar el cargo existente en la base de datos.
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarCargo(int id)
        {
            // Se establece una conexión a la base de datos utilizando la clase de conexión personalizada.
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                // Se utiliza un comando SQL almacenado llamado "EliminarCargo".
                using (SqlCommand cmd = new SqlCommand("EliminarCargo", connection))
                {
                    // Se especifica que el comando es de tipo procedimiento almacenado.
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Se asigna el parámetro del procedimiento almacenado con el valor proporcionado.
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;

                    // Se ejecuta el comando para eliminar el cargo de empleado de la base de datos.
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
