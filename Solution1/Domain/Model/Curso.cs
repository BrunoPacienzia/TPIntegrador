﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Curso
    {
        public int Id { get; set; }
        public  string Descripcion { get; set; }
        public  int AnioCalendario { get; set; }
        public  int Cupo { get; set; }
        public  int IdComision { get; set; }
        public  int IdMateria { get; set; }
    }
}
