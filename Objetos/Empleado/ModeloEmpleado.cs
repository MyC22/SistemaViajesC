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
        public Boolean Validar(Usuario u)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("Select Usuario from Usuario where (Usuario = @Usuario and Contrasena = @Contrasena)", con.Open());
            cmd.Parameters.AddWithValue("@Usuario", u.usuario);
            cmd.Parameters.AddWithValue("@Contrasena", u.contraseña);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true) {con.Close(); return true;}
            else {con.Close(); return  false;}
            
        }
        public DataTable listarEmpleado()
        {
            Conexion con = new Conexion();
            DataTable dt = new DataTable();
            SqlDataAdapter cmd = new SqlDataAdapter("Select e.ID,e.Nombres,e.Apellido,c.Cargo from Empleado as e inner join Cargo as c on e.IDCargo = c.ID", con.Open());
            cmd.Fill(dt);
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
            cmd.Parameters.AddWithValue("@Edad", e.edad);
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
    }
}
