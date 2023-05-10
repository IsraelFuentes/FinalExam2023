using System.ComponentModel.DataAnnotations;

namespace Mid_Term.Models
{
    public class Account
    {
        public Account() 
        {
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
