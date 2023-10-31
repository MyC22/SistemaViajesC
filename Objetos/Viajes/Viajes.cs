using System;

namespace Objetos
{
    public class Viajes
    {
        public class viaje
        {
            public int id { get; set; }
            public string origen { get; set; }
            public string destino { get; set; }
            public DateTime demora { get; set; }
        }
        public class turno
        {
            public int id { get; set; }
            public DateTime hora { get; set; }
        }
    }
}
