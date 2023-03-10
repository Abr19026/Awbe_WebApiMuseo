using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using WebApiMuseo.Entidades;

namespace WebApiMuseo
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Obra> Obras { get; set; }
        public DbSet<Exposicion> Exposiciones { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<ObraCine> ObrasCine { get; set; }
        public DbSet<ObraPintura> ObrasPintura { get; set; }


        public string DbPath { get; }
        public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }
    }
}
