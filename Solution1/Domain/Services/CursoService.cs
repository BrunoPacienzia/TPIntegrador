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

            return context.Cursos.Find(id);
        }

        public IEnumerable<Curso> GetAll()
        {
            using var context = new Context();

            return context.Cursos.Include(x => x.Comision).Include(x => x.Materia).ToList();
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
                cursoToUpdate.Materia = curso.Materia;
                cursoToUpdate.Comision = curso.Comision;
                context.SaveChanges();
            }
        }
    }
}

