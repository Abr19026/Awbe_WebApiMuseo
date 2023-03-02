using Microsoft.EntityFrameworkCore;
using WebApiMuseo.Entidades;

namespace WebApiMuseo
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Obra> Obras { get; set; }
        public DbSet<Exposicion> Exposiciones { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Sala> salas { get; set; }

        public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }

        
    }
}
