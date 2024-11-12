namespace _05_EF_Relationship.Entities
{
    internal class Product
    {
        public int ProductId { get; set; } // PK
        public string Name { get; set; }
        public int Stock { get; set; } = 50;
        public double Price { get; set; }
        public DateTime Date { get; set; }

        // Navigation Property
        public int CategoryRefId { get; set; } // FK
        public Category Category { get; set; }

        public ProductDetail ProductDetail { get; set; }
    }
}
