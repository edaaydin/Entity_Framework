using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _06_EF_DataAnnotationFluentAPI.Entities
{
    // Data Annotations ilgili sınıf yada property üzerine yazılır. Bir kaç tane her satıra yapılabilir.
    [Table("TblBook")]
    internal class Book
    {
        [Key] // Key kullandığımızda PK olarak ilgili property'i tanımlar.
        public int BookId { get; set; }

        [Required(AllowEmptyStrings = true, ErrorMessage = "Kitap Adı Zorunludur")] // Zorunlu
        [MaxLength(150, ErrorMessage = "Maksimum 150 karakter")]
        [Column("Description", Order = 2, TypeName = "nvarchar(150)")]
        public string Title { get; set; }

        //Navigation Prop
        [ForeignKey(nameof(Author))]
        public int AuthorId { get; set; }

        public Author Author { get; set; }

    }
}
