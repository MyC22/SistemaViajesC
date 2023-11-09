using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Objetos.Buses;

namespace Objetos.Buses
{
    internal class DatoBuss
    {
        Conexion conn = new Conexion();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DataTable td = new DataTable();
        public DataTable Mostrar_Buss()
        {
            try
            {
                cmd.Connection = conn.Open();
                cmd.CommandText = "SP_Mostrar_Buss";
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
                cmd.Connection = conn.Close();
            }
            return td;
        }
        public DataTable Buscar_Buss(string Placa)
        {
            try
            {
                cmd.Connection = conn.Open();
                cmd.CommandText = "SP_Buscar_Buss";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Placa", Placa);
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
                cmd.Connection = conn.Close();
            }
            return td;
        }
        public void Insertar_Buss(Buses obj)
        {
            try
            {
                cmd.Connection = conn.Open();
                cmd.CommandText = "SP_Insertar_Buss";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Placa", obj.Placa1);
                cmd.Parameters.AddWithValue("@IdModelo", obj.IdModelo);
                cmd.Parameters.AddWithValue("@Lugar", obj.Lugar1);
                cmd.Parameters.AddWithValue("@Disponibilidad", obj.Disponibilidad1);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                string msj = ex.ToString();
            }
            finally
            {
                cmd.Connection = conn.Close();
            }
        }
        public void Modificar_Buss(Buses obj)
        {
            try
            {
                cmd.Connection = conn.Open();
                cmd.CommandText = "SP_Modificar_Buss";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Placa", obj.Placa1);
                cmd.Parameters.AddWithValue("@IdModelo", obj.IdModelo);
                cmd.Parameters.AddWithValue("@Lugar", obj.Lugar1);
                cmd.Parameters.AddWithValue("@Disponibilidad", obj.Disponibilidad1);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                string msj = ex.ToString();
            }
            finally
            {
                cmd.Connection = conn.Close();
            }
        }
        public void Eliminar_Buss(Buses obj)
        {
            try
            {
                cmd.Connection = conn.Open();
                cmd.CommandText = "SP_Eliminar_Buss";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Placa", obj.Placa1);
                cmd.ExecuteReader();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                string msj = ex.ToString();
            }
            finally
            {
                cmd.Connection = conn.Close();
            }
        }
    }
}
