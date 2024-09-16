using Domain.Model;
using Domain.Services;

namespace WebAPI
{
    public class MateriaRouter
    {
        
        public static void Map(WebApplication app)
        {

            app.MapGet("/materias/{id}", (int id) =>
            {
                MateriaService materiaService = new MateriaService();

                return materiaService.Get(id);
            })
            .WithName("GetMateria")
            .WithOpenApi();


            app.MapGet("/materias", () =>
            {
                MateriaService materiaService = new MateriaService();

                return materiaService.GetAll();
            })
            .WithName("GetAllMaterias")
            .WithOpenApi();

            app.MapPost("/materias", (Materia materia) =>
            {
                MateriaService materiaService = new MateriaService();

                materiaService.Add(materia);
            })
            .WithName("AddMateria")
            .WithOpenApi();

            app.MapPut("/materias", (Materia materia) =>
            {
                MateriaService materiaService = new MateriaService();

                materiaService.Update(materia);
            })
            .WithName("UpdateMateria")
            .WithOpenApi();

            app.MapDelete("/materias/{id}", (int id) =>
            {
                MateriaService materiaService = new MateriaService();

                materiaService.Delete(id);
            })
            .WithName("DeleteMateria")
            .WithOpenApi();

        }


    }
}
