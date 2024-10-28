﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Persona
    {
        public int Id { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdPlan { get; set; }
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public int TipoPersona { get; set; }
    }
}