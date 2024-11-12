namespace _07_EF_LoadingType.Entitys
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        // Navigation Prop
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
