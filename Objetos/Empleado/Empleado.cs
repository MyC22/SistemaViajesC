namespace Objetos
{
    public class Empleado
    {
        public class empleado
        {
            public int id { get; set; }
            public string nombre { get; set; }
            public string apellido { get; set; }
            public string dni { get; set; }
            public int edad { get; set; }
            public string sexo { get; set; }
            public int cargo { get; set; }
        }
        public class cargo
        {
            public int id { get; set; }
            public string nombre { get; set; }
            public string descripcion { get; set; }
        }
        public class Usuario
        {
            public int id { get; set; }
            public string usuario { get; set; }
            public string contraseña { get; set; }
            public string tipo { get; set; }
        }
    }
}
