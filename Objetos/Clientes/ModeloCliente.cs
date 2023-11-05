using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Objetos
{
    public class ModeloCliente
    {
        private Conexion conexion;

        public ModeloCliente()
        {
            conexion = new Conexion();
        }

        public List<(Cliente, Lugar)> BuscarClientesPorDistrito(string distritoBusqueda)
        {
            List<(Cliente, Lugar)> clientes = new List<(Cliente, Lugar)>();

            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand cmd = new SqlCommand("BuscarClientePorDistrito", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DistritoBusqueda", distritoBusqueda);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cliente cliente = new Cliente();
                            Lugar lugar = new Lugar();
                            {
                                cliente.Nombres = reader["NombreCliente"].ToString();
                                cliente.Apellido = reader["ApellidoCliente"].ToString();
                                cliente.Celular = Convert.ToInt32(reader["CelularCliente"]);

                                lugar.Distrito = reader["DistritoViaje"].ToString();
                                lugar.Departamento = reader["DepartamentoViaje"].ToString();
                            };
                            clientes.Add((cliente, lugar));
                        }
                    }
                }
            }

            return clientes;
        }
        public List<Cliente> MostrarClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand cmd = new SqlCommand("MostrarCliente", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cliente cliente = new Cliente();
                            Lugar lugar = new Lugar();
                            {
                                cliente.Nombres = reader["NombreCliente"].ToString();
                                cliente.Apellido = reader["ApellidoCliente"].ToString();
                                cliente.Celular = Convert.ToInt32(reader["CelularCliente"]);

                                lugar.Distrito = reader["DistritoViaje"].ToString();
                                lugar.Departamento = reader["DepartamentoViaje"].ToString();
                            };
                            clientes.Add(cliente);
                        }
                    }
                }
            }

            return clientes;
        }

    }
}
