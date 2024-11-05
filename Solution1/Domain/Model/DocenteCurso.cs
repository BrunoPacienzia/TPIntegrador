using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class DocenteCurso
    {
        
        public int DocenteCursoId { get; set; } 
        public Curso Curso { get; set; }
        public Persona Docente { get; set; }

        public  string TipoCargo { get; set; }

    }

}
