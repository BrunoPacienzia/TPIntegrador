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


            if (alumnoInscripcion.Alumno.TipoPersona != 0) { throw new Exception("Tipo de ALUMNO invalido"); }

            alumnoInscripcion.Nota = 0;
            alumnoInscripcion.Condicion = "Cursando";

            CursoService cursoService = new CursoService();

            alumnoInscripcion.Curso.Cupo = alumnoInscripcion.Curso.Cupo - 1;

            cursoService.Update(alumnoInscripcion.Curso);

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

                    CursoService cursoService = new CursoService();

                    alumnoInscripcionToDelete.Curso.Cupo = alumnoInscripcionToDelete.Curso.Cupo + 1;

                    cursoService.Update(alumnoInscripcionToDelete.Curso);
             
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

                if (alumnoInscripcion.Nota < 4)
                {
                    alumnoInscripcion.Condicion = "Libre";
                }
                else if (alumnoInscripcion.Nota < 6)
                {
                    alumnoInscripcion.Condicion = "Regular";
                }
                else
                {
                    alumnoInscripcion.Condicion = "Aprobado";
                }

                alumnoInscripcionToUpdate.Condicion = alumnoInscripcion.Condicion;
                alumnoInscripcionToUpdate.Nota = alumnoInscripcion.Nota;
                context.SaveChanges();
            }
        }
    }
}
