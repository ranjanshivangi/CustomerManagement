using System.ComponentModel.DataAnnotations;


namespace CustomerManagement.Models
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? OrderName { get; set; }
        [Required]
        public decimal OrederPrice { get; set; }
        public int CustomerId { get; set; }
    }
}
