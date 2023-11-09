using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Buses
{
    public class Buses //Atributos
    {
      
        private int Placa;

        private int idModelo;

        private string Lugar;

        private DateTime Disponibilidad;

        public int Placa1 { get => Placa; set => Placa = value; }
        public int IdModelo { get => idModelo; set => idModelo = value; }
        public string Lugar1 { get => Lugar; set => Lugar = value; }
        public DateTime Disponibilidad1 { get => Disponibilidad; set => Disponibilidad = value; }
    }
}
