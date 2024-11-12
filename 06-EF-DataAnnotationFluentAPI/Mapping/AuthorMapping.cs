using _06_EF_DataAnnotationFluentAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _06_EF_DataAnnotationFluentAPI.Mapping
{
    internal class AuthorMapping : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder) // harici dosyalarda konfig. edilmesi için merkezi yapılandırma
        {
        //modelBuilder.Entity<Author>() // builder

            builder.Ignore(b => b.FullName);

            builder.HasData(
                    new Author
                    {
                        AuthorId = 1,
                        FirstName = "William",
                        LastName = "Shakespeare"
                    },
                    new Author
                    {
                        AuthorId = 2,
                        FirstName = "Fyodor",
                        LastName = "Dostoyeski"
                    },
                    new Author
                    {
                        AuthorId = 3,
                        FirstName = "Fatih",
                        LastName = "Alkan"
                    }
                );
        }
    }
}
