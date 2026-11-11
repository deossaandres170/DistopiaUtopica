using System;

namespace system_books.Models
{
    public class Usuario
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public bool Activo { get; set; }
        public Usuario()
        {
           Activo = true; 
        }
        public Usuario(string identificacion, string nombre, string correo)
        {
            Identificacion = identificacion;
            Nombre = Nombre;
            Correo = correo;
            Activo = true; 
        }
        public string ResumenCorto()
        {
            return $"{Nombre} (ID: {Identificacion})";
        }
        public string DetalleCompleto()
        {
            string estadoActivo = Activo ? "Activo" : "Inactivo";
            return $"Usuario -> ID: {Identificacion} | Nombre: {Nombre} | Correo: {Correo} | Estado: {estadoActivo}";
        }

        public override string ToString()
        {
            return ResumenCorto();
        }
    }

    
}