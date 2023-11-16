using Instituto.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Instituto.Datos
{
    public class InstitutoDbContext : DbContext
    {
        public InstitutoDbContext(DbContextOptions<InstitutoDbContext> options)
        :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Alumno>()
                .Property(p => p.Correo)
                .HasMaxLength(200);
            
            modelBuilder.Entity<Alumno>()
                .Property(p => p.Nombre)
                .HasMaxLength(150);


            // Data Seeding - Este proceso es para llenar datos iniciales
            modelBuilder.Entity<Alumno>()
                .HasData(new List<Alumno>()
                {
                    new() { Id = 1, Nombre = "Pepe", Correo = "pepe@gmail.com", Edad = 10 },
                    new() { Id = 2, Nombre = "Juan", Correo = "juan@gmail.com", Edad = 10 },
                    new() { Id = 3, Nombre = "Pedro", Correo = "pedro@gmail.com", Edad = 10 },
                });
        }
    }
}