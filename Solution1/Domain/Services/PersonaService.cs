using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class PersonaService
    {
        public void Add(Persona persona)
        {
            using var context = new Context();

            context.Personas.Add(persona);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new Context();

            Persona? personaToDelete = context.Personas.Find(id);

            if (personaToDelete != null)
            {
                context.Personas.Remove(personaToDelete);
                context.SaveChanges();
            }
        }

        public Persona? Get(int id)
        {
            using var context = new Context();

            return context.Personas.Find(id);
        }

        public IEnumerable<Persona> GetAll()
        {
            using var context = new Context();

            return context.Personas.ToList();
        }

        public void Update(Persona persona)
        {
            using var context = new Context();

            Persona? personaToUpdate = context.Personas.Find(persona.Id);

            if (personaToUpdate != null)
            {
                personaToUpdate.Nombre = persona.Nombre;
                personaToUpdate.Apellido = persona.Apellido;
                personaToUpdate.IdPlan = persona.IdPlan;
                personaToUpdate.Direccion = persona.Direccion;
                personaToUpdate.Email = persona.Email;
                personaToUpdate.FechaNacimiento = persona.FechaNacimiento;
                personaToUpdate.Legajo = persona.Legajo;
                personaToUpdate.Telefono = persona.Telefono;
                personaToUpdate.TipoPersona = persona.TipoPersona;

                context.SaveChanges();
            }
        }
    }
}
