using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Especialidad
    {
        public int EspecialidadId { get; set; }
        public string Descripcion { get; set; }
    }
}
