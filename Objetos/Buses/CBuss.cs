using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objetos.Buses;
namespace Objetos.Buses
{
    public class CBuss
    {
        DatoBuss carro = new DatoBuss();
        public DataTable MostrarBuss()
        {
            DataTable td = new DataTable();
            td = carro.Mostrar_Buss();
            return td;
        }

        public DataTable BuscarBuss(string Buscar)
        {
            DataTable td = new DataTable();
            td = carro.Buscar_Buss(Buscar);
            return td;
        }
        public void  InsertarBuss(Buses obj)
        {
            carro.Insertar_Buss(obj);
        }
        public void Modificar(Buses obj)
        {
            carro.Modificar_Buss(obj);
        }
    }
}
