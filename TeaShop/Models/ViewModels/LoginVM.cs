using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TeaShop.Models.ViewModels
{
    public class LoginVM
    {
        [Required]
        [EmailAddress]

        public string Email { get; set; }

        [Display(Name = "Hasło")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }

    }
}
