using System;

namespace Objetos
{
    public class Cliente
    {
        public class cliente
        {
            public int id { get; set; }
            public string nombre { get; set; }
            public string apellido { get; set; }
            public string dni { get; set; }
            public int celular { get; set; }
        }

        public class destino
        {
            public int id { get; set; }
            public string lugar { get; set;}

        }

        public class tipo 
        {
            public int id { get; set; }
            public string calidad {  get; set; }
        }
    }
}
