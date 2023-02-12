using System.ComponentModel.DataAnnotations;

namespace TeaShop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Kategoria")]
        public string CategoryName { get; set; }
        virtual public ISet<Product> Products { get; set; }

    }
}
