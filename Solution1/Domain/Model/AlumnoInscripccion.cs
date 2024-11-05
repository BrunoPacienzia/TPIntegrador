using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class AlumnoInscripccion
    {
        public int AlumnoInscripccionId { get; set; }
        public string Condicion { get; set; }
        public Persona Alumno { get; set; }
        public Curso Curso { get; set; }
        public int Nota { get; set; }
    }
}
