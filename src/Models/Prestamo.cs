using System;

namespace system_books.Models
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public Libro LibroPrestado { get; set; }
        public Usuario UsuarioPrestatario { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public EstadoPrestamo Estado { get; set; }

        public Prestamo()
        {
            FechaPrestamo = DateTime.Now;
            FechaDevolucion = null;
            Estado = EstadoPrestamo.Activo;
        }

        public Prestamo(int idPrestamo, Libro libro, Usuario usuario)
        {
            IdPrestamo = idPrestamo;
            LibroPrestado = libro;
            UsuarioPrestatario = usuario;
            FechaPrestamo = DateTime.Now;
            FechaDevolucion = null;
            Estado = EstadoPrestamo.Activo;
            
            if (libro != null) libro.Disponible = false;
        }

        public bool EstaVencido()
        {
            if (Estado == EstadoPrestamo.Devuelto) return false;
            return DiasTranscurridos() > 7;
        }

        public int DiasTranscurridos()
        {
            DateTime fechaFin = FechaDevolucion ?? DateTime.Now;
            TimeSpan diferencia = fechaFin - FechaPrestamo;
            return diferencia.Days;
        }

        public string ResumenCorto()
        {
            return $"Préstamo #{IdPrestamo} - Libro: {LibroPrestado?.Titulo} | Usuario: {UsuarioPrestatario?.Nombre} | Estado: {Estado}";
        }

        public string DetalleCompleto()
        {
            string fechaDevStr = FechaDevolucion.HasValue ? FechaDevolucion.Value.ToString("dd/MM/yyyy HH:mm") : "No devuelto aún";
            return $"Préstamo ID: {IdPrestamo}\n" +
                   $"  - {LibroPrestado?.DetalleCompleto()}\n" +
                   $"  - {UsuarioPrestatario?.DetalleCompleto()}\n" +
                   $"  - Fecha Préstamo: {FechaPrestamo:dd/MM/yyyy HH:mm}\n" +
                   $"  - Fecha Devolución: {fechaDevStr}\n" +
                   $"  - Estado: {Estado}\n" +
                   $"  - ¿Está vencido?: {(EstaVencido() ? "Sí" : "No")}\n" +
                   $"  - Días transcurridos: {DiasTranscurridos()}";
        }

        public override string ToString()
        {
            return ResumenCorto();
        }
    }
}