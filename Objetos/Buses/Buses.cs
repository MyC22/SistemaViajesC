using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Buses
{
    public class Buses //Atributos que necesita la tabla buses (estos estan encapsulados)
    {
        public string Placa { get; set; }
        public int IdModelo { get; set; }
        public string Lugar { get; set; }
        public DateTime Disponibilidad { get; set; }
    }
    public class listabuses
    {
        public string Placa { get; set; }

        public string modelo { get; set; }

        public string Lugar { get; set; }

        public DateTime Disponibilidad { get; set; }
    }
}
