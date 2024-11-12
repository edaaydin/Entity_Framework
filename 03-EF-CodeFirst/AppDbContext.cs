using Microsoft.EntityFrameworkCore;

namespace _03_EF_CodeFirst
{
    // DbContext, verilerle nesneler olarak etkileşim kurmaktan sorumlu olan birincil sınıftır. Nuget Package Manager'dan indirmemiz gerekir.
    internal class AppDbContext : DbContext
    {
        //DbSet, bir sınıfı bir databasedeki belirli bir tabloyla eşleştirmek için kullanılır. Kısaca veritabanı işlemlerine açılan ağ geçitidir.
        public DbSet<Author> Authors { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Book> Books { get; set; }

        // UseSqlServer için Nuget Package Manager (NPM) 
        //OnConfiguration, entity sql ile olan konfigürasyon ayarlarını gerçekleştirmek.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //"Server=.;Database=CodeFirst1;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;"
            optionsBuilder.UseSqlServer("Server=.;Database=CodeFirst1;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
        }

        // Fluent API
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Author>()
        //        .HasOne(a => a.Profile)
        //        .WithOne(a => a.Author)
        //        .HasForeignKey<Profile>(p => p.AuthorId);
        //}
    }
}
