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


                alumnoInscripcionService.Add(alumnoInscripcion);

            })
            .WithName("AddAlumnoInscripcion")
            .WithOpenApi();

            app.MapPut("/alumnoInscripciones", (AlumnoInscripcion alumnoInscripcion) =>
            {
                AlumnoInscripcionService alumnoInscripcionService = new AlumnoInscripcionService();


                alumnoInscripcionService.Update(alumnoInscripcion);
            })
            .WithName("UpdateAlumnoInscripcion")
            .WithOpenApi();

            app.MapDelete("/alumnoInscripciones/{id}", (int id) =>
            {
                AlumnoInscripcionService alumnoInscripcionService = new AlumnoInscripcionService();

                AlumnoInscripcion alumnoInscripcionABorrar = alumnoInscripcionService.Get(id);


                alumnoInscripcionService.Delete(id);
            })
            .WithName("DeleteAlumnoInscripcion")
            .WithOpenApi();

        }


    }
}
