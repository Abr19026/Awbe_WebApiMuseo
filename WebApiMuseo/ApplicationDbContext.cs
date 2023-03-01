using Microsoft.EntityFrameworkCore;
using WebApiMuseo.Entidades;

namespace WebApiMuseo
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Obra> Obras { get; set; }
    }
}
