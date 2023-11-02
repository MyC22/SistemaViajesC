using System;

namespace Objetos
{
    public class Boletos
    {
        public class boletos
        {
            public int id { get; set; }
            public int pasajero { get; set; }
            public int clase { get; set; }
            public int factura { get; set; }
            public double precio { get; set; }
        }
        public class recervacion
        {
            public int id { get; set; }
            public int pasajero { get; set; }
            public int clase { get; set; }
            public int cliente { get; set; }
            public DateTime limite { get; set; }
            public string estado { get; set; }
        }
    }
}
