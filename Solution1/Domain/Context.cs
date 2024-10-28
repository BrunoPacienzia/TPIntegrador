using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Domain
{
    internal class Context : DbContext
    {
        internal DbSet<Materia> Materias { get; set; }

        internal DbSet<Plan> Planes { get; set; }

        internal DbSet<Comision> Comisiones { get; set; }

        internal DbSet<Persona> Personas { get; set; }

        internal DbSet<Especialidad> Especialidades { get; set; }
        internal DbSet<Usuario> Usuarios { get; set; }

        internal DbSet<Curso> Cursos { get; set; }

        internal DbSet<DocenteCurso> DocentesCursos { get; set; }

        internal Context()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=TpDb");
    }
}
