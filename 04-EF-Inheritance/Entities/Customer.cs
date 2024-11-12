namespace _04_EF_Inheritance.Entities
{
    public class Customer : BasePerson
    {
        public DateTime LastPurchaseDate { get; set; }
        public int TotalVisit { get; set; }
    }
}
