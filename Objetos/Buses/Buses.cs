using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Buses
{
    public class Buses //Atributos que necesita la tabla buses (estos estan encapsulados)
    {
      
        private String Placa1;

        private int iDModelo;

        private string Lugar1;

        private DateTime Disponibilidad1;

        public String Placa { get => Placa1; set => Placa1 = value; }
        public int IdModelo { get => iDModelo; set => iDModelo = value; }
        public string Lugar { get => Lugar1; set => Lugar1 = value; }
        public DateTime Disponibilidad { get => Disponibilidad1; set => Disponibilidad1 = value; }
    }
}
