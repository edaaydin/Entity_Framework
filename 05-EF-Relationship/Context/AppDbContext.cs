using _05_EF_Relationship.Entities;
using Microsoft.EntityFrameworkCore;

namespace _05_EF_Relationship.Context
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=CodeFirst3;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // FluentAPI
            // One To Many
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.CategoryRefId);

            // One To One
            modelBuilder.Entity<Product>()
                .HasOne(p => p.ProductDetail)
                .WithOne(p => p.Product)
                .HasForeignKey<ProductDetail>(p => p.ProductRefId);

            //base.OnModelCreating(modelBuilder);
        }
    }
}
