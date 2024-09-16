using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class MateriaService
    {

        public void Add(Materia materia)
        {
            using var context = new Context();

            context.Materias.Add(materia);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new Context();

            Materia? materiaToDelete = context.Materias.Find(id);

            if (materiaToDelete != null)
            {
                context.Materias.Remove(materiaToDelete);
                context.SaveChanges();
            }
        }

        public Materia? Get(int id)
        {
            using var context = new Context();

            return context.Materias.Find(id);
        }

        public IEnumerable<Materia> GetAll()
        {
            using var context = new Context();

            return context.Materias.ToList();
        }

        public void Update(Materia materia)
        {
            using var context = new Context();

            Materia? materiaToUpdate = context.Materias.Find(materia.Id);

            if (materiaToUpdate != null)
            {
                materiaToUpdate.Nombre = materia.Nombre;
                materiaToUpdate.Descripcion = materia.Descripcion;
                materiaToUpdate.HSSemanales = materia.HSSemanales;
                materiaToUpdate.HSTotales = materia.HSTotales;
                materiaToUpdate.IdPlan = materia.IdPlan;
                context.SaveChanges();
            }
        }
    }
}
