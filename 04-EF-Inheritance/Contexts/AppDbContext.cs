using _04_EF_Inheritance.Entities;
using Microsoft.EntityFrameworkCore;

namespace _04_EF_Inheritance.Contexts
{
    public class AppDbContext: DbContext
    {
        //1. TPH (Table Per Hierarchy - Hiyerarşi Başına Tablo)
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<BasePerson> People { get; set; }
 


        //2. TPT(Table Per Type - Tür Başına Tablo)
        //public DbSet<Customer> Customers { get; set; }
        //public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //"Server=.;Database=CodeFirst1;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;"

            optionsBuilder.UseSqlServer("Server=.;Database=CodeFirst1;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
        }
    }
}
