using System.ComponentModel.DataAnnotations;

namespace _05_EF_Relationship.Entities
{
    internal class ProductDetail
    {
        public string Color { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
        [Key] //Data Annotation
        public int ProductRefId { get; set; } // PK, FK

        //Navigation Prop
        public Product Product { get; set; }
    }
}
