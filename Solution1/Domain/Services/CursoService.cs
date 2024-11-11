using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class CursoService
    {
        public void Add(Curso curso)
        {
            using var context = new Context();

            // Attach Plan associated with Comision and Materia only if it's not already tracked
            if (curso.Comision?.Plan != null)
            {
                var trackedPlan = context.Planes.Local.FirstOrDefault(p => p.PlanId == curso.Comision.Plan.PlanId);
                if (trackedPlan != null)
                {
                    // Reuse the tracked instance of Plan
                    curso.Comision.Plan = trackedPlan;
                }
                else
                {
                    // Attach Plan if not tracked
                    context.Attach(curso.Comision.Plan);
                }
            }

            if (curso.Materia?.Plan != null)
            {
                var trackedPlan = context.Planes.Local.FirstOrDefault(p => p.PlanId == curso.Materia.Plan.PlanId);
                if (trackedPlan != null)
                {
                    // Reuse the tracked instance of Plan
                    curso.Materia.Plan = trackedPlan;
                }
                else
                {
                    // Attach Plan if not tracked
                    context.Attach(curso.Materia.Plan);
                }
            }


            context.Attach(curso.Comision);
            context.Attach(curso.Materia);
            context.Cursos.Add(curso);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new Context();

            Curso? cursoToDelete = context.Cursos.Find(id);

            if (cursoToDelete != null)
            {
                context.Cursos.Remove(cursoToDelete);
                context.SaveChanges();
            }
        }

        public Curso? Get(int id)
        {
            using var context = new Context();

            return context.Cursos.Include(x => x.Comision).Include(x => x.Materia).FirstOrDefault(x => x.CursoId == id);
        }

        public IEnumerable<Curso> GetAll()
        {
            using var context = new Context();

            return context.Cursos.Include(x => x.Comision).Include(x => x.Materia).ToList();
        }

        public void Update(Curso curso)
        {
            using var context = new Context();

            Curso? cursoToUpdate = context.Cursos.Find(curso.CursoId);

            if (cursoToUpdate != null)
            {
                cursoToUpdate.Descripcion = curso.Descripcion;
                cursoToUpdate.Cupo = curso.Cupo;
                cursoToUpdate.AnioCalendario = curso.AnioCalendario;
               
                var materia = context.Materias
                    .Include(m => m.Plan) 
                    .FirstOrDefault(m => m.MateriaId == curso.Materia.MateriaId);
                if (materia != null)
                {
                    cursoToUpdate.Materia = materia;
                }

        
                var comision = context.Comisiones
                    .Include(c => c.Plan) 
                    .FirstOrDefault(c => c.ComisionId == curso.Comision.ComisionId);
                if (comision != null)
                {
                    cursoToUpdate.Comision = comision;
                }
                
                context.SaveChanges();
            }
        }
    }
}

