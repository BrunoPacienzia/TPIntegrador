using Domain.Model;
using Domain.Services;


namespace WebAPI
{
    public class DocenteCursoRouter
    {
        public static void Map(WebApplication app)
        {

            app.MapGet("/docentesCursos/{id}", (int id) =>
            {
                DocenteCursoService doenteCursoService = new DocenteCursoService();

                return doenteCursoService.Get(id);
            })
            .WithName("GetDocenteCurso")
            .WithOpenApi();


            app.MapGet("/docentesCursos", () =>
            {
                DocenteCursoService doenteCursoService = new DocenteCursoService();

                return doenteCursoService.GetAll();
            })
            .WithName("GetAllDocenteCursos")
            .WithOpenApi();

            app.MapPost("/docentesCursos", (DocenteCurso doenteCurso) =>
            {
                DocenteCursoService doenteCursoService = new DocenteCursoService();

                if (doenteCurso.Docente.TipoPersona != 1) { throw new Exception("Tipo de DOCENTE invalido"); }

                doenteCursoService.Add(doenteCurso);
            })
            .WithName("AddDocenteCurso")
            .WithOpenApi();

            app.MapPut("/docentesCursos", (DocenteCurso doenteCurso) =>
            {
                DocenteCursoService doenteCursoService = new DocenteCursoService();

                if (doenteCurso.Docente.TipoPersona != 1) { throw new Exception("Tipo de DOCENTE invalido"); }

                doenteCursoService.Update(doenteCurso);
            })
            .WithName("UpdateDocenteCurso")
            .WithOpenApi();

            app.MapDelete("/docentesCursos/{id}", (int id) =>
            {
                DocenteCursoService doenteCursoService = new DocenteCursoService();

                doenteCursoService.Delete(id);
            })
            .WithName("DeleteDocenteCurso")
            .WithOpenApi();

        }

    }
}
