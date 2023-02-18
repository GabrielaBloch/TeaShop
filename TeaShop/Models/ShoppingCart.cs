using System.ComponentModel.DataAnnotations;

namespace TeaShop.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public bool IsDeleted { get; set; } = false;

        public ICollection<CartDetails> CartDetail { get; set; }
    }
}
