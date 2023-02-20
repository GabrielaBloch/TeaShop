using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeaShop.Models
{
    [Table("Products")]
    public class Product
    {
       
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        [Display(Name = "Opis")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Cena")]
        public float Price { get; set; }
        [Required]
        [Display(Name = "Waga")]
        public float Weight { get; set; }
        [Required]
        [Display(Name = "Na stanie")]
        public int Amount { get; set; }
        [Required]
        public ProductPhoto ProductPhoto { get; set; }
        [Display(Name = "Zdjęcie")]
        public int PhotoId { get; set; }
        public string? ProductImage { get; set; }

        [NotMapped]
        public string CategoryName { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }




    }
}
