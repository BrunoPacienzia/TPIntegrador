using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class UsuarioService
    {
        public void Add(Usuario usuario)
        {
            using var context = new Context();

            context.Usuarios.Add(usuario);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new Context();

            Usuario? usuarioToDelete = context.Usuarios.Find(id);

            if (usuarioToDelete != null)
            {
                context.Usuarios.Remove(usuarioToDelete);
                context.SaveChanges();
            }
        }

        public Usuario? Get(int id)
        {
            using var context = new Context();

            return context.Usuarios.Find(id);
        }

        public IEnumerable<Usuario> GetAll()
        {
            using var context = new Context();

            return context.Usuarios.ToList();
        }

        public void Update(Usuario usuario)
        {
            using var context = new Context();

            Usuario? usuarioToUpdate = context.Usuarios.Find(usuario.UsuarioId);

            if (usuarioToUpdate != null)
            {
                usuarioToUpdate.Nombre = usuario.Nombre;
                usuarioToUpdate.Apellido = usuario.Apellido;
                usuarioToUpdate.Clave = usuario.Clave;
                usuarioToUpdate.Habilitado = usuario.Habilitado;
                usuarioToUpdate.Email = usuario.Email;
                usuarioToUpdate.NombreUsuario = usuario.NombreUsuario;

                context.SaveChanges();
            }
        }
    }
}
