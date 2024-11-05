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
        public int PlanId { get; set; }
        public string Descripcion { get; set; }
        public Especialidad Especialidad { get; set; }

    }
}
