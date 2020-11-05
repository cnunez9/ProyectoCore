using Dominio;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class CursosOnlineContext : IdentityDbContext<Usuario>
    {
        public CursosOnlineContext(DbContextOptions options): base(options){

            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CursoInstructor>().HasKey(ci => new {ci.InstructorId,ci.CursoId});
            //modelBuilder.Entity<Precio>().Property(c => c.PrecioActual).HasColumnType("decimal(18, 4)");
            //modelBuilder.Entity<Precio>().Property(c => c.Promocion).HasColumnType("decimal(18, 4)");
        }
        //Comentario
        public DbSet<Comentario> Comentario {get;set;}

        public DbSet<Curso> Curso {get;set;}
        public DbSet<CursoInstructor> CursoInstructor {get;set;}
        public DbSet<Instructor> Instructor {get;set;}
        public DbSet<Precio> Precio {get;set;}
    }
}