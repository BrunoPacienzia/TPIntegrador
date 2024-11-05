using Domain.Model;
using Domain.Services;

namespace WebAPI
{
    public class AlumnoInscripcionRouter
    {

        public static void Map(WebApplication app)
        {

            app.MapGet("/alumnoInscripcciones/{id}", (int id) =>
            {
                AlumnoInscripcionService alumnoInscripccionService = new AlumnoInscripcionService();

                return alumnoInscripccionService.Get(id);
            })
            .WithName("GetAlumnoInscripcion")
            .WithOpenApi();


            app.MapGet("/alumnoInscripcciones", () =>
            {
                AlumnoInscripcionService alumnoInscripccionService = new AlumnoInscripcionService();

                return alumnoInscripccionService.GetAll();
            })
            .WithName("GetAllAlumnoInscripciones")
            .WithOpenApi();

            app.MapPost("/alumnoInscripcciones", (AlumnoInscripcion alumnoInscripccion) =>
            {
                AlumnoInscripcionService alumnoInscripccionService = new AlumnoInscripcionService();

                alumnoInscripccionService.Add(alumnoInscripccion);
            })
            .WithName("AddAlumnoInscripcion")
            .WithOpenApi();

            app.MapPut("/alumnoInscripcciones", (AlumnoInscripcion alumnoInscripccion) =>
            {
                AlumnoInscripcionService alumnoInscripccionService = new AlumnoInscripcionService();

                alumnoInscripccionService.Update(alumnoInscripccion);
            })
            .WithName("UpdateAlumnoInscripcion")
            .WithOpenApi();

            app.MapDelete("/alumnoInscripcciones/{id}", (int id) =>
            {
                AlumnoInscripcionService alumnoInscripccionService = new AlumnoInscripcionService();

                alumnoInscripccionService.Delete(id);
            })
            .WithName("DeleteAlumnoInscripcion")
            .WithOpenApi();

        }


    }
}
