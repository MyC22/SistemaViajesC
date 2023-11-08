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
        public List<Modelo> BuscarModelos(int? id, string nombre, int tamaño)
        {

        }

        public List<Modelo> MostrarTodosLosModelos()
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand cmd = new SqlCommand("MostrarTodosLosModelos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                }
            }
        }
    }
}
