using System.ComponentModel.DataAnnotations;

namespace TeaShop.Models
{
    public class OrderStatus
    {
        public int Id { get; set; }
        [Required]
        public int StatusId { get; set; }
        [Required]
        public string? StatusName { get; set; }
    }
}
