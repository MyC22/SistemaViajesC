using System;

namespace Objetos
{
    public class ClientePersona
    {
        public int ID { get; set; }
        public string Nombres { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public int Celular { get; set; }
        public string Correo { get; set; }
        public DateTime Nacimiento { get; set; }
        public string Tipo { get; set; }

    }
    public class ClienteEmpresa
    {
        public int ID { get; set; }
        public string Nombres { get; set; }
        public int Celular { get; set; }
        public string Correo { get; set; }
        public int Ruc { get; set; }
        public string Direccion { get; set; }
        public string Tipo { get; set; }
    }
    public class Cliente
    {
        public int ID { get; set; }
        public string Nombres { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public int Celular { get; set; }
        public string Correo { get; set; }
        public int Ruc { get; set; }
        public DateTime Nacimiento { get; set; }
        public string Direccion { get; set; }
        public string Tipo { get; set; }

    }
    public class ClienteListaPersona
    {
        public int ID { get; set; }
        public string Nombres { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }

    }
    public class ClienteListaEmpresa
    {
        public int ID { get; set; }
        public string Nombres { get; set; }
        public string Ruc { get; set; }
        public string Correo { get; set; }

    }


    public class Lugar
    {
        public int ID { get; set; }
        public string Distrito { get; set; }
        public string Direccion { get; set; }
        public string Terminal { get; set; }
        public string Departamento { get; set; }
        public string Estado { get; set; }
    }
}
