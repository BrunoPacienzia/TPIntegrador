using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class PlanService
    {

        public void Add(Plan plan)
        {
            using var context = new Context();

            context.Attach(plan.Especialidad);
            context.Planes.Add(plan);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new Context();

            Plan? planToDelete = context.Planes.Find(id);

            if (planToDelete != null)
            {
                context.Planes.Remove(planToDelete);
                context.SaveChanges();
            }
        }

        public Plan? Get(int id)
        {
            using var context = new Context();

            return context.Planes.Include(x => x.Especialidad) 
        .FirstOrDefault(x => x.PlanId == id); ;
        }

        public IEnumerable<Plan> GetAll()
        {
            using var context = new Context();

            return context.Planes.Include(x => x.Especialidad).ToList();
        }

        public void Update(Plan plan)
        {
            using var context = new Context();

            Plan? planToUpdate = context.Planes.Find(plan.PlanId);

            if (planToUpdate != null)
            {
                planToUpdate.Descripcion = plan.Descripcion;
                planToUpdate.Especialidad = plan.Especialidad;
                context.SaveChanges();
            }
        }
    }
}

