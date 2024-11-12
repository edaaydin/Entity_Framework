namespace _04_EF_Inheritance.Entities
{
    public class Employee : BasePerson
    {
        public DateTime AdmissionDate { get; set; }
        public string JobDescription { get; set; }
    }
}
