using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ComisionService
    {
        public void Add(Comision comision)
        {
            using var context = new Context();

            context.Comisiones.Add(comision);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new Context();

            Comision? comisionToDelete = context.Comisiones.Find(id);

            if (comisionToDelete != null)
            {
                context.Comisiones.Remove(comisionToDelete);
                context.SaveChanges();
            }
        }

        public Comision? Get(int id)
        {
            using var context = new Context();

            return context.Comisiones.Find(id);
        }

        public IEnumerable<Comision> GetAll()
        {
            using var context = new Context();

            return context.Comisiones.ToList();
        }

        public void Update(Comision comision)
        {
            using var context = new Context();

            Comision? comisionToUpdate = context.Comisiones.Find(comision.Id);

            if (comisionToUpdate != null)
            {
                comisionToUpdate.Descripcion = comision.Descripcion;
                comisionToUpdate.AnioEspecialidad = comision.AnioEspecialidad;
                comisionToUpdate.IdPlan = comision.IdPlan;
                context.SaveChanges();
            }
        }
    }
}
