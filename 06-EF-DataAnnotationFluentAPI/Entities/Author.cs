using System.ComponentModel.DataAnnotations.Schema;

namespace _06_EF_DataAnnotationFluentAPI.Entities
{	
    internal class Author
    {
		private string firstName;
		private string lastName;

        public int AuthorId { get; set; }
        public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		[NotMapped] // Bu kolon veritabanında oluşmayacak
        public string FullName{ get { return firstName + " " + lastName; } }

        // Navigation Prop
        public ICollection<Book> Books { get; set; }
    }
}
