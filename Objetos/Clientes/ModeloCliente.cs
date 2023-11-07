using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static Objetos.Empleado;

namespace Objetos
{
    public class ModeloCliente
    {

        public List<(Cliente, Lugar)> BuscarClientesPorDistrito(string distritoBusqueda)
        {
            Conexion conexion = new Conexion();
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
        public List<ClienteListaPersona> MostrarClientePersona()
        {
            Conexion conexion = new Conexion();
            List<ClienteListaPersona> clientes = new List<ClienteListaPersona>();

            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand cmd = new SqlCommand("MostrarClientePersona", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClienteListaPersona cliente = new ClienteListaPersona();
                            {
                                cliente.ID = (int)reader["ID"];
                                cliente.Nombres = reader["Nombres"].ToString();
                                cliente.Apellido = reader["Apellido"].ToString();
                                cliente.DNI = reader["DNI"].ToString();
                            };
                            clientes.Add(cliente);
                        }
                    }
                }
            }

            return clientes;
        }
        public List<ClienteListaEmpresa> MostrarClienteEmpresa()
        {
            Conexion conexion = new Conexion();
            List<ClienteListaEmpresa> clientes = new List<ClienteListaEmpresa>();

            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand cmd = new SqlCommand("MostrarClienteEmpresa", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClienteListaEmpresa cliente = new ClienteListaEmpresa();
                            {
                                cliente.ID = (int)reader["ID"];
                                cliente.Nombres = reader["Nombres"].ToString();
                                cliente.Ruc = reader["Ruc"].ToString();
                                cliente.Correo = reader["Correo"].ToString();
                            };
                            clientes.Add(cliente);
                        }
                    }
                }
            }

            return clientes;
        }
        public Boolean ValidarDni(ClientePersona c)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("Select DNI from Cliente where DNI = @dni", con.Open());
            cmd.Parameters.AddWithValue("@dni", c.DNI);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true) { con.Close(); return true; }
            else { con.Close(); return false; }
        }
        public Boolean ValidarRuc(ClienteEmpresa c)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("Select Ruc from Cliente where Ruc = @Ruc", con.Open());
            cmd.Parameters.AddWithValue("@Ruc", c.Ruc);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true) { con.Close(); return true; }
            else { con.Close(); return false; }
        }
        public void guardarEmpresa(ClienteEmpresa c)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("guardarEmpresa", con.Open());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", c.Nombres);
            cmd.Parameters.AddWithValue("@ruc", c.Ruc);
            cmd.Parameters.AddWithValue("@correo", c.Correo);
            cmd.Parameters.AddWithValue("@celular", c.Celular);
            cmd.Parameters.AddWithValue("@tipo", c.Tipo);
            cmd.Parameters.AddWithValue("@direccion", c.Direccion);
            cmd.ExecuteNonQuery();
        }
        public void guardarPersona(ClientePersona c)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("guardarPersona", con.Open());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", c.Nombres);
            cmd.Parameters.AddWithValue("@Apellido", c.Apellido);
            cmd.Parameters.AddWithValue("@dni", c.DNI);
            cmd.Parameters.AddWithValue("@correo", c.Correo);
            cmd.Parameters.AddWithValue("@celular", c.Celular);
            cmd.Parameters.AddWithValue("@tipo", c.Tipo);
            cmd.Parameters.AddWithValue("@nacimiento", c.Nacimiento);
            cmd.ExecuteNonQuery();
        }
        public SqlDataReader listarClienteID(int id)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("select * from CLiente where ID = @id", con.Open());
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public void eliminarcliente(int id)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("Delete from CLiente where ID = @id", con.Open());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
        public void editarCliente(Cliente c)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("editarCliente", con.Open());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", c.ID);
            cmd.Parameters.AddWithValue("@nombre", c.Nombres);
            cmd.Parameters.AddWithValue("@Apellido", c.Apellido);
            cmd.Parameters.AddWithValue("@dni", c.DNI);
            cmd.Parameters.AddWithValue("@correo", c.Correo);
            cmd.Parameters.AddWithValue("@celular", c.Celular);
            cmd.Parameters.AddWithValue("@tipo", c.Tipo);
            cmd.Parameters.AddWithValue("@nacimiento", c.Nacimiento);
            cmd.Parameters.AddWithValue("@ruc", c.Ruc);
            cmd.Parameters.AddWithValue("@direccion", c.Direccion);
            cmd.ExecuteNonQuery();
        }
    }
}
