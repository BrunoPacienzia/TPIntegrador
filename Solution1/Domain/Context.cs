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

        internal DbSet<AlumnoInscripcion> AlumnoInscripciones { get; set; }

        internal DbSet<DocenteCurso> DocentesCursos { get; set; }

        internal Context()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Evita conflictos de borrado ya que ambas entidades contienen una referencia a plan

            modelBuilder.Entity<Curso>()
                .HasOne(c => c.Comision)
                .WithMany() 
                .HasForeignKey("ComisionId") 
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Curso>()
                .HasOne(c => c.Materia)
                .WithMany() 
                .HasForeignKey("MateriaId") 
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Persona>()
                .HasIndex(c => c.Legajo)
                .IsUnique()
                .HasName("IX_Persona_Legajo_Unico");

            modelBuilder.Entity<Plan>()
                .HasIndex(c => c.Descripcion)
                .IsUnique()
                .HasName("IX_Plan_Desc_Unico");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=TpDb");
    }
}
