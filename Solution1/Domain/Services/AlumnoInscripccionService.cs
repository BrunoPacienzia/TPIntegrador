using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class AlumnoInscripccionService
    {
        public void Add(AlumnoInscripccion alumnoInscripccion)
        {
            using var context = new Context();

            context.AlumnoInscripcciones.Add(alumnoInscripccion);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new Context();

            AlumnoInscripccion? alumnoInscripccionToDelete = context.AlumnoInscripcciones.Find(id);

            if (alumnoInscripccionToDelete != null)
            {
                context.AlumnoInscripcciones.Remove(alumnoInscripccionToDelete);
                context.SaveChanges();
            }
        }

        public AlumnoInscripccion? Get(int id)
        {
            using var context = new Context();

            return context.AlumnoInscripcciones.Find(id);
        }

        public IEnumerable<AlumnoInscripccion> GetAll()
        {
            using var context = new Context();

            return context.AlumnoInscripcciones.ToList();
        }

        public void Update(AlumnoInscripccion alumnoInscripccion)
        {
            using var context = new Context();

            AlumnoInscripccion? alumnoInscripccionToUpdate = context.AlumnoInscripcciones.Find(alumnoInscripccion.Id);

            if (alumnoInscripccionToUpdate != null)
            {
                alumnoInscripccionToUpdate.Condicion = alumnoInscripccion.Condicion;
                alumnoInscripccionToUpdate.IdAlumno = alumnoInscripccion.IdAlumno;
                alumnoInscripccionToUpdate.IdCurso = alumnoInscripccion.IdCurso;
                alumnoInscripccionToUpdate.Nota = alumnoInscripccion.Nota;
                context.SaveChanges();
            }
        }
    }
}
