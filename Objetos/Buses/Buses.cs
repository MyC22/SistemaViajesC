using System;

namespace Objetos
{
    public class Buses
    {
        public class buses
        {
            public int id { get; set; }
            public int modelo { get; set; }
            public string placa { get; set; }
            public string lugar { get; set; }
            public DateTime disponible { get; set; }
        }
        public class modelo
        {
            public int id { get; set; }
            public string nombre { get; set; }
            public string tamaño { get; set; }
            public int asientos { get; set; }
            public int pisos { get; set; }
        }

    }
}
