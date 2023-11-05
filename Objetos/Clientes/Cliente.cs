using System;

namespace Objetos
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nombres { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public int Celular { get; set; }
    }

    public class Lugar
    {
        public int ID { get; set; }
        public string Distrito { get; set; }
        public string Direccion { get; set; }
        public string Terminal { get; set; }
        public string Departamento { get; set; }
        public string Estado { get; set; }
    }
}
