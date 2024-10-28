using Domain.Model;
using Domain.Services;

namespace WebAPI
{
    public class EspecialidadRouter
    {
        public static void Map(WebApplication app)
        {

            app.MapGet("/especialidades/{id}", (int id) =>
            {
                EspecialidadService especialidadService = new EspecialidadService();

                return especialidadService.Get(id);
            })
            .WithName("GetEspecialidad")
            .WithOpenApi();


            app.MapGet("/especialidades", () =>
            {
                EspecialidadService especialidadService = new EspecialidadService();

                return especialidadService.GetAll();
            })
            .WithName("GetAllEspecialidads")
            .WithOpenApi();

            app.MapPost("/especialidades", (Especialidad especialidad) =>
            {
                EspecialidadService especialidadService = new EspecialidadService();

                especialidadService.Add(especialidad);
            })
            .WithName("AddEspecialidad")
            .WithOpenApi();

            app.MapPut("/especialidades", (Especialidad especialidad) =>
            {
                EspecialidadService especialidadService = new EspecialidadService();

                especialidadService.Update(especialidad);
            })
            .WithName("UpdateEspecialidad")
            .WithOpenApi();

            app.MapDelete("/especialidades/{id}", (int id) =>
            {
                EspecialidadService especialidadService = new EspecialidadService();

                especialidadService.Delete(id);
            })
            .WithName("DeleteEspecialidad")
            .WithOpenApi();

        }

    }
}
