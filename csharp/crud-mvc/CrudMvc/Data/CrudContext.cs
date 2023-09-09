using CrudMvc.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace CrudMvc.Data
{
    public class CrudContext : DbContext
    {
        public CrudContext(DbContextOptions<CrudContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMap());
        }

        public DbSet<CrudMvc.Models.Product> Product { get; set; } = default!;
    }
}
