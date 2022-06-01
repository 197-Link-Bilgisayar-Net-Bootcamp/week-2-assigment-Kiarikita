using Microsoft.EntityFrameworkCore;
using ProductFinder.Entities;

namespace ProductFinder.DataAccess
{
    public class ProductDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost; Database=ProductDb; trusted_connection = True;");
        }

        public DbSet<Product> Products { get; set; }
    }
}
