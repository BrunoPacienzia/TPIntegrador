﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class DocenteCurso
    {
        
        public int Id { get; set; } 
        public int IdCurso { get; set; }
        public int IdDocente { get; set; }

        public  string TipoCargo { get; set; }

    }

}
