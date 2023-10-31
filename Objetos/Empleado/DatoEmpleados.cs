using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DatoEmpleado.Conexion;
using System.Data;
using Empleado.Atributos;

namespace DatoEmpleado.Entidades
{
    public class DatoEmpleados
    {
        //Variables
        ConexionBD conn = new ConexionBD();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DataTable td = new DataTable();

        public DataTable Mostrar()
        {
            try
            {
                cmd.Connection = conn.OpenConnection();
                cmd.CommandText = "SP_Mostrar";
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();
                td.Load(dr);
            }
            catch (Exception ex)
            {
                string msj = ex.ToString();
            }
            finally
            {
                cmd.Connection = conn.CloseConnection();
            }
            return td;
        }

        public DataTable Buscar(string Buscar)
        {
            try
            {
                cmd.Connection = conn.OpenConnection();
                cmd.CommandText = "SP_Buscar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Buscar", Buscar);
                dr = cmd.ExecuteReader();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                td.Load(dr);
            }
            catch (Exception ex)
            {
                string msj = ex.ToString();
            }
            finally
            {
                cmd.Connection = conn.CloseConnection();
            }
            return td;
        }

        public void Insertar(Empleados obj)
        {
            try
            {
                cmd.Connection = conn.OpenConnection();
                cmd.CommandText = "SP_Insertar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", obj.ID);
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", obj.Apellido);
                cmd.Parameters.AddWithValue("@Sexo", obj.Sexo);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                string msj = ex.ToString();
            }
            finally
            {
                cmd.Connection = conn.CloseConnection();
            }
        }

        public void Modificar(Empleados obj)
        {
            try
            {
                cmd.Connection = conn.OpenConnection();
                cmd.CommandText = "SP_Modificar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", obj.ID);
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", obj.Apellido);
                cmd.Parameters.AddWithValue("@Sexo", obj.Sexo);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                string msj = ex.ToString();
            }
            finally
            {
                cmd.Connection = conn.CloseConnection();
            }
        }

        public void Eliminar(Empleados obj)
        {
            try
            {
                cmd.Connection = conn.OpenConnection();
                cmd.CommandText = "SP_Eliminar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", obj.ID);
                cmd.ExecuteReader();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                string msj = ex.ToString();
            }
            finally
            {
                cmd.Connection = conn.CloseConnection();
            }
        }
    }
}
