using Domain.Model;
using Domain.Services;

namespace WebAPI
{
    public class UsuarioRouter
    {
        public static void Map(WebApplication app)
        {

            app.MapGet("/usuarios/{id}", (int id) =>
            {
                UsuarioService usuarioService = new UsuarioService();

                return usuarioService.Get(id);
            })
            .WithName("GetUsuario")
            .WithOpenApi();


            app.MapGet("/usuarios", () =>
            {
                UsuarioService usuarioService = new UsuarioService();

                return usuarioService.GetAll();
            })
            .WithName("GetAllUsuarios")
            .WithOpenApi();

            app.MapPost("/usuarios", (Usuario usuario) =>
            {
                UsuarioService usuarioService = new UsuarioService();

                usuarioService.Add(usuario);
            })
            .WithName("AddUsuario")
            .WithOpenApi();

            app.MapPut("/usuarios", (Usuario usuario) =>
            {
                UsuarioService usuarioService = new UsuarioService();

                usuarioService.Update(usuario);
            })
            .WithName("UpdateUsuario")
            .WithOpenApi();

            app.MapDelete("/usuarios/{id}", (int id) =>
            {
                UsuarioService usuarioService = new UsuarioService();

                usuarioService.Delete(id);
            })
            .WithName("DeleteUsuario")
            .WithOpenApi();

        }
    }
}
