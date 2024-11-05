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
        public void Add(AlumnoInscripcion alumnoInscripccion)
        {
            using var context = new Context();

            context.Attach(alumnoInscripccion.Alumno);
            context.Attach(alumnoInscripccion.Curso);
            context.AlumnoInscripciones.Add(alumnoInscripccion);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new Context();

            AlumnoInscripcion? alumnoInscripccionToDelete = context.AlumnoInscripciones.Find(id);

            if (alumnoInscripccionToDelete != null)
            {
                context.AlumnoInscripciones.Remove(alumnoInscripccionToDelete);
                context.SaveChanges();
            }
        }

        public AlumnoInscripcion? Get(int id)
        {
            using var context = new Context();

            return context.AlumnoInscripciones.Find(id);
        }

        public IEnumerable<AlumnoInscripcion> GetAll()
        {
            using var context = new Context();

            return context.AlumnoInscripciones.Include(x => x.Alumno).Include(x => x.Curso).ToList();
        }

        public void Update(AlumnoInscripcion alumnoInscripccion)
        {
            using var context = new Context();

            AlumnoInscripcion? alumnoInscripccionToUpdate = context.AlumnoInscripciones.Find(alumnoInscripccion.AlumnoInscripcionId);

            if (alumnoInscripccionToUpdate != null)
            {
                alumnoInscripccionToUpdate.Condicion = alumnoInscripccion.Condicion;
                alumnoInscripccionToUpdate.Alumno = alumnoInscripccion.Alumno;
                alumnoInscripccionToUpdate.Curso = alumnoInscripccion.Curso;
                alumnoInscripccionToUpdate.Nota = alumnoInscripccion.Nota;
                context.SaveChanges();
            }
        }
    }
}
