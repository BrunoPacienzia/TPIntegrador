﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Especialidad
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; }
        public required string Descripccion { get; set; }
    }
}
