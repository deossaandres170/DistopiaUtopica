using System;
using System.Collections.Generic;
using System.Linq;
using system_books.Models;


namespace DistopiaUtopica.Services
{
    public class UsuarioService
    {
        private List<Usuario> usuarios = new List<Usuario>();

        // 3. Operaciones básicas
        public void AgregarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public bool EliminarUsuario(string documento)
        {
            var usuario = BuscarPorDocumento(documento);
            if (usuario != null)
            {
                return usuarios.Remove(usuario);
            }
            return false;
        }

        public List<Usuario> ObtenerTodos()
        {
            return usuarios;
        }

        // 4. Búsquedas (por documento o nombre)
        public Usuario? BuscarPorDocumento(string documento)
        {
            return usuarios.FirstOrDefault(u => u.Identificacion.Equals(documento, StringComparison.OrdinalIgnoreCase));
        }

        public List<Usuario> BuscarPorNombre(string nombre)
        {
            return usuarios.Where(u => u.Nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        // 5. Ordenación (por nombre)
        public List<Usuario> OrdenarPorNombre()
        {
            return usuarios.OrderBy(u => u.Nombre).ToList();
        }
    }
}