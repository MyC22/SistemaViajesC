using System;
using System.Globalization;

namespace Objetos
{
    public class comprobante
    {
        public string id { get; set; }
        public int idcliente { get; set; }
        public double precio { get; set; }
        public double igv { get; set; }
        public double precioT { get; set; }
        public DateTime fecha { get; set; }
        public String tipocomporbante { get; set; } 

    }
}
