using Domain.Model;
using Domain.Services;

namespace WebAPI
{
    public class CursoRouter
    {
        public static void Map(WebApplication app)
        {

            app.MapGet("/cursos/{id}", (int id) =>
            {
                CursoService cursoService = new CursoService();

                return cursoService.Get(id);
            })
            .WithName("GetCurso")
            .WithOpenApi();


            app.MapGet("/cursos", () =>
            {
                CursoService cursoService = new CursoService();

                return cursoService.GetAll();
            })
            .WithName("GetAllCursos")
            .WithOpenApi();

            app.MapPost("/cursos", (Curso curso) =>
            {
                CursoService cursoService = new CursoService();

                cursoService.Add(curso);
            })
            .WithName("AddCurso")
            .WithOpenApi();

            app.MapPut("/cursos", (Curso curso) =>
            {
                CursoService cursoService = new CursoService();

                cursoService.Update(curso);
            })
            .WithName("UpdateCurso")
            .WithOpenApi();

            app.MapDelete("/cursos/{id}", (int id) =>
            {
                CursoService cursoService = new CursoService();

                cursoService.Delete(id);
            })
            .WithName("DeleteCurso")
            .WithOpenApi();

        }


    }
}
