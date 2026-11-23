using System;
using System.Collections.Generic;
using System.Linq;
using system_books.Models;

namespace  DistopiaUtopica.Services
{
    public class LibroService
    {
        private List<Libro> libros = new List<Libro>();

        // 3. Operaciones básicas
        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
        }

        public bool EliminarLibro(string isbn)
        {
            var libro = BuscarPorIsbn(isbn);
            if (libro != null)
            {
                return libros.Remove(libro);
            }
            return false;
        }

        public List<Libro> ObtenerTodos()
        {
            return libros;
        }

        // 4. Búsquedas (por ISBN, título o autor)
        public Libro? BuscarPorIsbn(string isbn)
        {
            return libros.FirstOrDefault(l => l.Isbn.Equals(isbn, StringComparison.OrdinalIgnoreCase));
        }

        public List<Libro> BuscarPorTitulo(string titulo)
        {
            return libros.Where(l => l.Titulo.Contains(titulo, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Libro> BuscarPorAutor(string autor)
        {
            return libros.Where(l => l.Autor.Contains(autor, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        // 5. Ordenación (por título o año)
        public List<Libro> OrdenarPorTitulo()
        {
            return libros.OrderBy(l => l.Titulo).ToList();
        }

        public List<Libro> OrdenarPorAnio()
        {
            return libros.OrderBy(l => l.AnioPublicacion).ToList(); // Ajusta al nombre exacto de tu propiedad Año
        }
    }
}