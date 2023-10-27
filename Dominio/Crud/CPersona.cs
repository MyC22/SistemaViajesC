using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoDatos.Entidades;
using Comun.Atributos;

namespace Dominio.Crud
{
    public class CPersona
    {
        Persona persona = new Persona();

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


        public void Insertar(AttributesPeople obj)
        {
            persona.Insertar(obj);
        }

        public void Modificar(AttributesPeople obj)
        {
            persona.Modificar(obj);
        }

        public void Eliminar(AttributesPeople obj)
        {
            persona.Eliminar(obj);
        }
    }
}
