using Microsoft.EntityFrameworkCore;
using ProductFinder.Entities;

namespace ProductFinder.DataAccess
{
    public class ProductDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //connection stringi vererek server bağlantısını oluşturup, migration ile ProductDb adlı databasei oluşturacak
            optionsBuilder.UseSqlServer("Server=localhost; Database=ProductDb; trusted_connection = True;");
        }

        /*ProductDbContext classını newlediğimiz zaman Products diye bir property gelecek
         bu property ise DbSet türünden olduğu için add, find gibi database işlemleri yapan methodlara ulaşmış olacağız*/

        public DbSet<Product> Products { get; set; }
    }
}
