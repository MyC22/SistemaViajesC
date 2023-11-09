using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objetos;


namespace Objetos
{
    public class Rutas
    {
        public int ID { get; set; }
        public int IDOrigen { get; set; }
        public int IDDestino { get; set; }
        public string Nombre { get; set; }
        public TimeSpan Demora { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
    }

}
