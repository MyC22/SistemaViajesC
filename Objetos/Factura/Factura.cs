using System;

namespace Objetos
{
    public class Factura
    {
        public string id { get; set; }
        public int cliente { get; set; }
        public int programacion { get; set; }
        public int empleado { get; set; }
        public double precio { get; set; }
        public DateTime fecha { get; set; }
    }
}
