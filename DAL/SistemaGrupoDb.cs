using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    public class SistemaGrupoDb : DbContext
    {
        public SistemaGrupoDb() : base("name = ConStr")
        {

        }

        public virtual DbSet<Grupos> Grupos { get; set; }
        public virtual DbSet<Estudiantes> Estudiantes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grupos>()
                .HasMany<Estudiantes>(g => g.Estudiantes)
                .WithMany(e => e.Grupos)
                .Map(ge =>
                {
                    ge.MapLeftKey("EstudianteId");
                    ge.MapRightKey("GrupoId");
                    ge.ToTable("GruposEstudiantes");
                });
        }
    }
}
