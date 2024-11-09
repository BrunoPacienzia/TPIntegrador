using Domain.Model;
using Domain.Services;

namespace WebAPI
{
    public class AlumnoInscripcionRouter
    {

        public static void Map(WebApplication app)
        {

            app.MapGet("/alumnoInscripciones/{id}", (int id) =>
            {
                AlumnoInscripcionService alumnoInscripcionService = new AlumnoInscripcionService();

                return alumnoInscripcionService.Get(id);
            })
            .WithName("GetAlumnoInscripcion")
            .WithOpenApi();


            app.MapGet("/alumnoInscripciones", () =>
            {
                AlumnoInscripcionService alumnoInscripcionService = new AlumnoInscripcionService();

                return alumnoInscripcionService.GetAll();
            })
            .WithName("GetAllAlumnoInscripciones")
            .WithOpenApi();

            app.MapPost("/alumnoInscripciones", (AlumnoInscripcion alumnoInscripcion) =>
            {
                AlumnoInscripcionService alumnoInscripcionService = new AlumnoInscripcionService();

                if (alumnoInscripcion.Alumno.TipoPersona != 0 ) { throw new Exception("Tipo de ALUMNO invalido"); }

                alumnoInscripcion.Nota = 0;
                alumnoInscripcion.Condicion = "Cursando";

                CursoService cursoService = new CursoService();

                alumnoInscripcion.Curso.Cupo = alumnoInscripcion.Curso.Cupo - 1;

                cursoService.Update(alumnoInscripcion.Curso);

                alumnoInscripcionService.Add(alumnoInscripcion);

            })
            .WithName("AddAlumnoInscripcion")
            .WithOpenApi();

            app.MapPut("/alumnoInscripciones", (AlumnoInscripcion alumnoInscripcion) =>
            {
                AlumnoInscripcionService alumnoInscripcionService = new AlumnoInscripcionService();

                if (alumnoInscripcion.Nota < 4)
                {
                    alumnoInscripcion.Condicion = "Libre";
                }
                else if (alumnoInscripcion.Nota < 6)
                {
                    alumnoInscripcion.Condicion = "Regular";
                }
                else
                {
                    alumnoInscripcion.Condicion = "Aprobado";
                }

                alumnoInscripcionService.Update(alumnoInscripcion);
            })
            .WithName("UpdateAlumnoInscripcion")
            .WithOpenApi();

            app.MapDelete("/alumnoInscripciones/{id}", (int id) =>
            {
                AlumnoInscripcionService alumnoInscripcionService = new AlumnoInscripcionService();

                AlumnoInscripcion alumnoInscripcionABorrar = alumnoInscripcionService.Get(id);

                if (alumnoInscripcionABorrar != null) {
                    CursoService cursoService = new CursoService();

                    alumnoInscripcionABorrar.Curso.Cupo = alumnoInscripcionABorrar.Curso.Cupo + 1;

                    cursoService.Update(alumnoInscripcionABorrar.Curso);
                }

                alumnoInscripcionService.Delete(id);
            })
            .WithName("DeleteAlumnoInscripcion")
            .WithOpenApi();

        }


    }
}
