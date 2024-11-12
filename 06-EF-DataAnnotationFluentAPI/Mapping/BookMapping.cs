using _06_EF_DataAnnotationFluentAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _06_EF_DataAnnotationFluentAPI.Mapping
{
    internal class BookMapping : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.BookId); // PK

            builder.Property(b => b.Title)
                .IsRequired(true)
                .HasMaxLength(150);

            builder.ToTable("TblBook");

            builder.Property(b => b.Title)
                .HasColumnName("Description")
                .HasColumnOrder(2)
                .HasColumnType("nvarchar(150)");

        }
    }
}
