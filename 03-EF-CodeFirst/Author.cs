namespace _03_EF_CodeFirst
{
    // Id, AuthorId kendisi otomatik Primary KEY (PK) ve Auto increment (1,1)
    internal class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        // Navigation Property
        public Profile Profile { get; set; }

        public List<Book> Books { get; set; }

    }
}
