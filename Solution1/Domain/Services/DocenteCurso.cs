using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class DocenteCursoService
    {
        public void Add(DocenteCurso docenteCurso)
        {
            using var context = new Context();

            context.DocentesCursos.Add(docenteCurso);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new Context();

            DocenteCurso? docenteCursoToDelete = context.DocentesCursos.Find(id);

            if (docenteCursoToDelete != null)
            {
                context.DocentesCursos.Remove(docenteCursoToDelete);
                context.SaveChanges();
            }
        }

        public DocenteCurso? Get(int id)
        {
            using var context = new Context();

            return context.DocentesCursos.Find(id);
        }

        public IEnumerable<DocenteCurso> GetAll()
        {
            using var context = new Context();

            return context.DocentesCursos.ToList();
        }

        public void Update(DocenteCurso docenteCurso)
        {
            using var context = new Context();

            DocenteCurso? docenteCursoToUpdate = context.DocentesCursos.Find(docenteCurso.Id);

            if (docenteCursoToUpdate != null)
            {
                docenteCursoToUpdate.IdDocente = docenteCurso.IdDocente;
                docenteCursoToUpdate.TipoCargo = docenteCurso.TipoCargo;
                context.SaveChanges();
            }
        }
    }
}

