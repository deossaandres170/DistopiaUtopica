using System;

namespace system_books.Models
{


    public class Libro
    {
        public string Isbn { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnioPublicacion { get; set; }
        public bool Disponible { get; set; }

        public Libro()
        {
            Disponible = true; 
        }

        public Libro(string isbn, string titulo, string autor, int anioPublicacion)
        {
            Isbn = isbn;
            Titulo = titulo;
            Autor = autor;
            AnioPublicacion = anioPublicacion;
            Disponible = true; 
        }

        public string ResumenCorto()
        {
            return $"[{Isbn}] '{Titulo}' por {Autor}";
        }

        public string DetalleCompleto()
        {
            string estadoDisp = Disponible ? "Disponible" : "Prestado";
            return $"Libro -> ISBN: {Isbn} | Título: {Titulo} | Autor: {Autor} | Año: {AnioPublicacion} | Estado: {estadoDisp}";
        }

        public override string ToString()
        {
            return ResumenCorto();
        }
    }

}