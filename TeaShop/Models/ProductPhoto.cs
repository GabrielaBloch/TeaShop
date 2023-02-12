using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeaShop.Models
{
    public class ProductPhoto
    {
        [Key]
        public int Id { get; set; }
        public Product Product { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public string ImageName { get; set; }

        public string ImagePath { get; set; }
        [FromForm]
        [NotMapped]
        public IFormFileCollection Files { get; set; }
    }
}
