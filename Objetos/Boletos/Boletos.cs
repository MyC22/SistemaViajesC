using System;

namespace Objetos
{
    public class boletos
    {
        public int id { get; set; }
        public int idpasajero { get; set; }
        public int idservicio { get; set; }
        public int idfactura { get; set; }
        public double precio { get; set; }
    }
    public class pasajero
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set;}
    }
}
