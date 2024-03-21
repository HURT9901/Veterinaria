using Microsoft.EntityFrameworkCore;

namespace Veterinaria.API.Controllers.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) {
        
        }
        public DbSet<Owner>Owners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
