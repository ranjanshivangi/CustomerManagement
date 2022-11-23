using System.ComponentModel.DataAnnotations;


namespace CustomerManagement.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }        
        public string? Email { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }

    }
}
