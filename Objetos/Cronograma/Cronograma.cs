using System;

namespace Objetos
{

    public class cronograma
    {
        public int id { get; set; }
        public string placabus { get; set; }
        public int idruta { get; set; }
        public DateTime fechasalida { get; set; }
        public string usuario { get; set; }
    }
    public class Servicios
    {
        public int id { get; set; }
        public int idcronograma { get; set; }
        public string nombre { get; set; }
        public double preciop1 { get; set; }
        public double preciop2 { get; set; }
    }
    public class cronogramalista
    {
        public int id { get; set; }
        public string placabus { get; set; }
        public double preciop1 { get; set; }
        public double preciop2 { get;set; }
        public string Ruta { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public string servicio { get; set; }
        public DateTime fecha { get; set; }


    }

}
