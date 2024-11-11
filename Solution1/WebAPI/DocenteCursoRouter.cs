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
                DocenteCursoService docenteCursoService = new DocenteCursoService();

                return docenteCursoService.Get(id);
            })
            .WithName("GetDocenteCurso")
            .WithOpenApi();


            app.MapGet("/docentesCursos", () =>
            {
                DocenteCursoService docenteCursoService = new DocenteCursoService();

                return docenteCursoService.GetAll();
            })
            .WithName("GetAllDocenteCursos")
            .WithOpenApi();

            app.MapPost("/docentesCursos", (DocenteCurso docenteCurso) =>
            {
                DocenteCursoService docenteCursoService = new DocenteCursoService();

                if (docenteCurso.Docente.TipoPersona != 1) { throw new Exception("Tipo de DOCENTE invalido"); }

                docenteCursoService.Add(docenteCurso);
            })
            .WithName("AddDocenteCurso")
            .WithOpenApi();

            app.MapPut("/docentesCursos", (DocenteCurso docenteCurso) =>
            {
                DocenteCursoService docenteCursoService = new DocenteCursoService();

                if (docenteCurso.Docente.TipoPersona != 1) { throw new Exception("Tipo de DOCENTE invalido"); }

                docenteCursoService.Update(docenteCurso);
            })
            .WithName("UpdateDocenteCurso")
            .WithOpenApi();

            app.MapDelete("/docentesCursos/{id}", (int id) =>
            {
                DocenteCursoService docenteCursoService = new DocenteCursoService();

                docenteCursoService.Delete(id);
            })
            .WithName("DeleteDocenteCurso")
            .WithOpenApi();

        }

    }
}
