using Domain.Model;
using Domain.Services;

namespace WebAPI
{
    public class PersonaRouter
    {

        public static void Map(WebApplication app)
        {

            app.MapGet("/personas/{id}", (int id) =>
            {
                PersonaService personaService = new PersonaService();

                return personaService.Get(id);
            })
            .WithName("GetPersona")
            .WithOpenApi();


            app.MapGet("/personas", () =>
            {
                PersonaService personaService = new PersonaService();

                return personaService.GetAll();
            })
            .WithName("GetAllPersonas")
            .WithOpenApi();

            app.MapPost("/personas", (Persona persona) =>
            {
                PersonaService personaService = new PersonaService();

                personaService.Add(persona);
            })
            .WithName("AddPersona")
            .WithOpenApi();

            app.MapPut("/personas", (Persona persona) =>
            {
                PersonaService personaService = new PersonaService();
                
                personaService.Update(persona);
            })
            .WithName("UpdatePersona")
            .WithOpenApi();

            app.MapDelete("/personas/{id}", (int id) =>
            {
                PersonaService personaService = new PersonaService();

                personaService.Delete(id);
            })
            .WithName("DeletePersona")
            .WithOpenApi();

        }


    }
}
