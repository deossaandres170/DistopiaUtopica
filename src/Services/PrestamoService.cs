using System;
using System.Collections.Generic;
using System.Linq;
using system_books.Models;


namespace DistopiaUtopica.Services
{
    public class PrestamoService
    {
        private List<Prestamo> prestamos = new List<Prestamo>();

        // 3. Operaciones básicas
        public void AgregarPrestamo(Prestamo prestamo)
        {
            prestamos.Add(prestamo);
        }

        public bool EliminarPrestamo(int id)
        {
            var prestamo = BuscarPorId(id);
            if (prestamo != null)
            {
                return prestamos.Remove(prestamo);
            }
            return false;
        }

        public List<Prestamo> ObtenerTodos()
        {
            return prestamos;
        }

        // 4. Búsquedas (por ID o estado)
        public Prestamo? BuscarPorId(int id)
        {
            return prestamos.FirstOrDefault(p => p.IdPrestamo == id);
        }

        public List<Prestamo> BuscarPorEstado(EstadoPrestamo estado)
        {
            return prestamos.Where(p => p.Estado == estado).ToList();
        }

        // 5. Ordenación (por fecha límite)
        public List<Prestamo> OrdenarPorFechaLimite()
        {
            return prestamos.OrderBy(p => p.FechaDevolucion).ToList(); // Ajusta al nombre de tu propiedad de fecha límite
        }
    }
}