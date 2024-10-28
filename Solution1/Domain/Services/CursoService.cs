using Domain.Model;
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

            return context.Cursos.Find(id);
        }

        public IEnumerable<Curso> GetAll()
        {
            using var context = new Context();

            return context.Cursos.ToList();
        }

        public void Update(Curso curso)
        {
            using var context = new Context();

            Curso? cursoToUpdate = context.Cursos.Find(curso.Id);

            if (cursoToUpdate != null)
            {
                cursoToUpdate.Descripcion = curso.Descripcion;
                cursoToUpdate.Cupo = curso.Cupo;
                cursoToUpdate.AnioCalendario = curso.AnioCalendario;
                cursoToUpdate.IdMateria = curso.IdMateria;
                cursoToUpdate.IdComision = curso.IdComision;
                context.SaveChanges();
            }
        }
    }
}

