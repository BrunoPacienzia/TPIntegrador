using Domain.Model;
using Domain.Services;

namespace WebAPI
{
    public class AlumnoInscripccionRouter
    {

        public static void Map(WebApplication app)
        {

            app.MapGet("/alumnoInscripcciones/{id}", (int id) =>
            {
                AlumnoInscripccionService alumnoInscripccionService = new AlumnoInscripccionService();

                return alumnoInscripccionService.Get(id);
            })
            .WithName("GetAlumnoInscripccion")
            .WithOpenApi();


            app.MapGet("/alumnoInscripcciones", () =>
            {
                AlumnoInscripccionService alumnoInscripccionService = new AlumnoInscripccionService();

                return alumnoInscripccionService.GetAll();
            })
            .WithName("GetAllAlumnoInscripcciones")
            .WithOpenApi();

            app.MapPost("/alumnoInscripcciones", (AlumnoInscripccion alumnoInscripccion) =>
            {
                AlumnoInscripccionService alumnoInscripccionService = new AlumnoInscripccionService();

                alumnoInscripccionService.Add(alumnoInscripccion);
            })
            .WithName("AddAlumnoInscripccion")
            .WithOpenApi();

            app.MapPut("/alumnoInscripcciones", (AlumnoInscripccion alumnoInscripccion) =>
            {
                AlumnoInscripccionService alumnoInscripccionService = new AlumnoInscripccionService();

                alumnoInscripccionService.Update(alumnoInscripccion);
            })
            .WithName("UpdateAlumnoInscripccion")
            .WithOpenApi();

            app.MapDelete("/alumnoInscripcciones/{id}", (int id) =>
            {
                AlumnoInscripccionService alumnoInscripccionService = new AlumnoInscripccionService();

                alumnoInscripccionService.Delete(id);
            })
            .WithName("DeleteAlumnoInscripccion")
            .WithOpenApi();

        }


    }
}
