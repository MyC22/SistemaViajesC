using System;

namespace Objetos
{
    public class Programacion
    {
        public class programacion
        {
            public int id { get; set; }
            public int bus { get; set; }
            public string origen { get; set; }
            public string destino { get; set; }
            public DateTime salida { get; set; }
            public DateTime llegada { get; set; }
        }
        public class clase
        {
            public int id { get; set; }
            public int programacion { get; set; }
            public string nombre { get; set; }
            public double precio { get; set; }
        }
    }

}
