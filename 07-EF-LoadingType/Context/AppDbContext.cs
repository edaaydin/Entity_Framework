using _07_EF_LoadingType.Entitys;
using Microsoft.EntityFrameworkCore;

namespace _07_EF_LoadingType.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.; Database = CodeFirst7; Trusted_Connection = True; MultipleActiveResultSets = true; TrustServerCertificate = True;");

            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
