using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TeaShop.Models.ViewModels
{
    public class RegisterVM
    {
        [Required]
        [Display(Name = "Imię")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        [StringLength(100, ErrorMessage = "Hasło {0} musi mieć conajmniej {2} znaków", MinimumLength = 6)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Potwierdź hasło")]
        [Compare("Password", ErrorMessage = "Wpisane hasła różnią się")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Rola")]
        public string RoleName { get; set; }
    }
}
