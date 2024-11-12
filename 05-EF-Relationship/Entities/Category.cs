namespace _05_EF_Relationship.Entities
{
    internal class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        //Navigation Property
        public List<Product> Products { get; set; }
    }
}
