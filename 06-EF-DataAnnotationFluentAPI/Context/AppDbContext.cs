using _06_EF_DataAnnotationFluentAPI.Entities;
using _06_EF_DataAnnotationFluentAPI.Mapping;
using Microsoft.EntityFrameworkCore;

namespace _06_EF_DataAnnotationFluentAPI.Context
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.; Database = CodeFirst6; Trusted_Connection = True; MultipleActiveResultSets = true; TrustServerCertificate = True;");
        }

        // Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Book>().HasKey(x => x.BookId); // PK

            //modelBuilder.Entity<Book>()
            //    .Property(b => b.Title)
            //    .IsRequired(true)
            //    .HasMaxLength(150);

            //modelBuilder.Entity<Book>()
            //    .ToTable("TblBook");

            //modelBuilder.Entity<Book>()
            //    .Property(b => b.Title)
            //    .HasColumnName("Description")
            //    .HasColumnOrder(2)
            //    .HasColumnType("nvarchar(150)");

            modelBuilder.ApplyConfiguration(new BookMapping()); // diger dosyalardaki yolu gosterir.

            modelBuilder.ApplyConfiguration(new AuthorMapping());


            //modelBuilder.Entity<Author>()
            //    .Ignore(b => b.FullName);

            //Seed Data, veritabanı ilk oluştuğunda default değerler yüklemek için kullanılır.

            //modelBuilder.Entity<Author>()
            //    .HasData(
            //        new Author
            //        {
            //            AuthorId = 1,
            //            FirstName = "William",
            //            LastName = "Shakespeare"
            //        },
            //        new Author
            //        {
            //            AuthorId = 2,
            //            FirstName = "Fyodor",
            //            LastName = "Dostoyeski"
            //        },
            //        new Author
            //        {
            //            AuthorId = 3,
            //            FirstName = "Fatih",
            //            LastName = "Alkan"
            //        }
            //    );
        }
    }
}
