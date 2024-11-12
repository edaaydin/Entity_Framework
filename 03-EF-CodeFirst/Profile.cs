
namespace _03_EF_CodeFirst
{
    // PK: Primary Key: Unique (tekil, eşsiz) // Id, ClassNameId
    // Identity (1, 1)
    internal class Profile
    {
        public int ProfileId { get; set; }  // PK: Primary Key
        public DateTime DogumTarihi { get; set; }
        public string Email { get; set; }

        //Navigation Property
        public int AuthorId { get; set; } // FK: Foreign Key
        public Author Author { get; set; }
    }
}
