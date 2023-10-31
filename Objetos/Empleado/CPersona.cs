using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DatoEmpleado.Entidades;
using Empleado.Atributos;

namespace Dominio.Crud
{
    public class CPersona
    {
        DatoEmpleados persona = new DatoEmpleados();

        public DataTable Mostrar()
        {
            DataTable td = new DataTable();
            td = persona.Mostrar();
            return td;
        }

        public DataTable Buscar(string Buscar)
        {
            DataTable td = new DataTable();
            td = persona.Buscar(Buscar);
            return td;
        }


        public void Insertar(Empleados obj)
        {
            persona.Insertar(obj);
        }

        public void Modificar(Empleados obj)
        {
            persona.Modificar(obj);
        }

        public void Eliminar(Empleados obj)
        {
            persona.Eliminar(obj);
        }
    }
}
