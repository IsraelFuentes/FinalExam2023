using System.ComponentModel.DataAnnotations;

namespace Mid_Term.Models
{
    public class Products
    {
        public Products() { }
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string NameOfProduct { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
