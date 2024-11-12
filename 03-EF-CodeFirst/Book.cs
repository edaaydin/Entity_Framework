namespace _03_EF_CodeFirst
{
    internal class Book
    {
        public int Id { get; set; } // Primary Key ve Identity (1,1)
        public string Title { get; set; } // nvarchar(max)  IS NOT NULL
        public int? PageSize { get; set; } // int Is NULL

        // Navigation Property
        public int AuthorId { get; set; }
        public Author Author { get; set; }        
    }
}