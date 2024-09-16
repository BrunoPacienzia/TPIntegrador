using Domain.Model;
using Domain.Services;

namespace WebAPI
{
    public class PlanRouter
    {

        public static void Map(WebApplication app)
    {
 app.MapGet("/planes/{id}", (int id) =>
            {
                PlanService planService = new PlanService();

                return planService.Get(id);
            })
            .WithName("GetPlan")
            .WithOpenApi();


            app.MapGet("/planes", () =>
            {
                PlanService planService = new PlanService();

                return planService.GetAll();
            })
            .WithName("GetAllPlans")
            .WithOpenApi();

            app.MapPost("/planes", (Plan plan) =>
            {
                PlanService planService = new PlanService();

                planService.Add(plan);
            })
            .WithName("AddPlan")
            .WithOpenApi();

            app.MapPut("/planes", (Plan plan) =>
            {
                PlanService planService = new PlanService();

                planService.Update(plan);
            })
            .WithName("UpdatePlan")
            .WithOpenApi();

            app.MapDelete("/planes/{id}", (int id) =>
            {
                PlanService planService = new PlanService();

                planService.Delete(id);
            })
            .WithName("DeletePlan")
            .WithOpenApi();
    }
 


    }
}
