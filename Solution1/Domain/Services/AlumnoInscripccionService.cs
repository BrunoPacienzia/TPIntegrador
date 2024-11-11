using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class AlumnoInscripcionService
    {
        public void Add(AlumnoInscripcion alumnoInscripcion)
        {
            using var context = new Context();

            context.Attach(alumnoInscripcion.Alumno);
            context.Attach(alumnoInscripcion.Curso);
            context.AlumnoInscripciones.Add(alumnoInscripcion);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new Context();

            AlumnoInscripcion? alumnoInscripcionToDelete = context.AlumnoInscripciones.Find(id);

            if (alumnoInscripcionToDelete != null)
            {
                context.AlumnoInscripciones.Remove(alumnoInscripcionToDelete);
                context.SaveChanges();
            }
        }

        public AlumnoInscripcion? Get(int id)
        {
            using var context = new Context();

            return context.AlumnoInscripciones.Include(x => x.Alumno).Include(x => x.Curso).FirstOrDefault(x => x.AlumnoInscripcionId == id);
        }

        public IEnumerable<AlumnoInscripcion> GetAll()
        {
            using var context = new Context();

            return context.AlumnoInscripciones.Include(x => x.Alumno).Include(x => x.Curso).ToList();
        }

        public void Update(AlumnoInscripcion alumnoInscripcion)
        {
            using var context = new Context();

            AlumnoInscripcion? alumnoInscripcionToUpdate = context.AlumnoInscripciones.Find(alumnoInscripcion.AlumnoInscripcionId);

            if (alumnoInscripcionToUpdate != null)
            {
                alumnoInscripcionToUpdate.Condicion = alumnoInscripcion.Condicion;
                alumnoInscripcionToUpdate.Alumno = alumnoInscripcion.Alumno;
                alumnoInscripcionToUpdate.Curso = alumnoInscripcion.Curso;
                alumnoInscripcionToUpdate.Nota = alumnoInscripcion.Nota;
                context.SaveChanges();
            }
        }
    }
}
