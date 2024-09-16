using Domain.Model;
using Domain.Services;

namespace WebAPI
{
    public class ComisionRouter
    {

        public static void Map(WebApplication app)
        {

            app.MapGet("/comisiones/{id}", (int id) =>
            {
                ComisionService comisionService = new ComisionService();

                return comisionService.Get(id);
            })
            .WithName("GetComision")
            .WithOpenApi();


            app.MapGet("/comisiones", () =>
            {
                ComisionService comisionService = new ComisionService();

                return comisionService.GetAll();
            })
            .WithName("GetAllComisiones")
            .WithOpenApi();

            app.MapPost("/comisiones", (Comision comision) =>
            {
                ComisionService comisionService = new ComisionService();

                comisionService.Add(comision);
            })
            .WithName("AddComision")
            .WithOpenApi();

            app.MapPut("/comisiones", (Comision comision) =>
            {
                ComisionService comisionService = new ComisionService();

                comisionService.Update(comision);
            })
            .WithName("UpdateComision")
            .WithOpenApi();

            app.MapDelete("/comisiones/{id}", (int id) =>
            {
                ComisionService comisionService = new ComisionService();

                comisionService.Delete(id);
            })
            .WithName("DeleteComision")
            .WithOpenApi();

        }


    }
}

