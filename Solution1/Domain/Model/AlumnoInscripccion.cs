using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class AlumnoInscripccion
    {
        public int Id { get; set; }
        public string Condicion { get; set; }
        public string IdAlumno { get; set; }
        public string IdCurso { get; set; }
        public int Nota { get; set; }
    }
}
