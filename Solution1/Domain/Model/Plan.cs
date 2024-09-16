using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Plan
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int IdEspecialidad { get; set; }

    }
}
