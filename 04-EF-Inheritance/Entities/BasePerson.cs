namespace _04_EF_Inheritance.Entities
{
    // Instance'ını oluşturmak istemiyorum. Sadece Miras verebilsin. İnheritance
    public abstract class BasePerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
    }
}