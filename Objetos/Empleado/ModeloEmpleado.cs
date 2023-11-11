using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static Objetos.Empleado;

namespace Objetos
{
    public class ModeloEmpleado
    {
        

        public SqlDataReader leerUsuario()
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("Select * from Usuario", con.Open());
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public Boolean ValidarUser(Usuario u)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("Select Usuario from Usuario where Usuario = @Usuario", con.Open());
            cmd.Parameters.AddWithValue("@Usuario", u.usuario);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true) {con.Close(); return true; }
            else {con.Close(); return false;}
        }
        public Boolean ValidarDni(empleado e)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("Select Dni from Empleado where Dni = @dni", con.Open());
            cmd.Parameters.AddWithValue("@dni", e.dni);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true) { con.Close(); return true; }
            else { con.Close(); return false; }
        }
        public string  Validar(Usuario u)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("Select Usuario from Usuario where (Usuario = @Usuario and Contrasena = @Contrasena)", con.Open());
            cmd.Parameters.AddWithValue("@Usuario", u.usuario);
            cmd.Parameters.AddWithValue("@Contrasena", u.contraseña);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if(dr.FieldCount < 2)
                { return dr["Usuario"].ToString();}
                else { return ""; }
            }else { return ""; }
            
        }
        public DataTable listarEmpleado()
        {
            Conexion con = new Conexion();
            DataTable dt = new DataTable();
            SqlDataAdapter cmd = new SqlDataAdapter("Select e.ID,e.Nombres,e.Apellido,e.Dni,c.Cargo from Empleado as e inner join Cargo as c on e.IDCargo = c.ID", con.Open());
            cmd.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable buscarEmpleado(String filtro, String nombre)
        {
            Conexion con = new Conexion();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("buscarEmpleado", con.Open());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@filtro", filtro);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            dr.Fill(dt);
            con.Close();
            return dt;
        }
        public void guardarEmpleado(empleado e,Usuario u)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("guardarEmpleado", con.Open());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", e.nombre);
            cmd.Parameters.AddWithValue("@apellido", e.apellido);
            cmd.Parameters.AddWithValue("@Dni", e.dni);
            cmd.Parameters.AddWithValue("@nacimiento", e.nacimiento);
            cmd.Parameters.AddWithValue("@sexo", e.sexo);
            cmd.Parameters.AddWithValue("@idcargo", e.cargo);
            cmd.Parameters.AddWithValue("@usuario", u.usuario);
            cmd.Parameters.AddWithValue("@tipo", u.tipo);
            cmd.Parameters.AddWithValue("@contrasena", u.contraseña);
            cmd.ExecuteNonQuery();

        }
        public DataTable listarcargos()
        {
            Conexion con = new Conexion();
            DataTable dt = new DataTable();
            SqlDataAdapter cmd = new SqlDataAdapter("select ID,Cargo from Cargo", con.Open());
            cmd.Fill(dt);
            con.Close();
            return dt;
        }
        public SqlDataReader listarEmpleadoId(int id)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("listarEmpleadoId", con.Open());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;

        }
        public void editarEmpleado(empleado e, Usuario u)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("editarEmpleado", con.Open());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idempleado", e.id);
            cmd.Parameters.AddWithValue("@nombre", e.nombre);
            cmd.Parameters.AddWithValue("@apellido", e.apellido);
            cmd.Parameters.AddWithValue("@Dni", e.dni);
            cmd.Parameters.AddWithValue("@nacimiento", e.nacimiento);
            cmd.Parameters.AddWithValue("@sexo", e.sexo);
            cmd.Parameters.AddWithValue("@idcargo", e.cargo);
            cmd.Parameters.AddWithValue("@usuario", u.usuario);
            cmd.Parameters.AddWithValue("@tipo", u.tipo);
            cmd.Parameters.AddWithValue("@contrasena", u.contraseña);
            cmd.ExecuteNonQuery();

        }
        public void eliminarEmpleado(int id)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("eliminarEmpleado", con.Open());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

    }
}
