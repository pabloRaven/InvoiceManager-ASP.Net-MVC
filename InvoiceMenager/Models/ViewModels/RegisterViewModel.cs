using InvoiceMenager.Models.Domains;
using System.ComponentModel.DataAnnotations;

namespace InvoiceMenager.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Poczta")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Potwierdź hasło ")]
        [Compare("Password", ErrorMessage = "Podane hasło  różni się  wpisanego hasło.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Nazwa")]
        public string Name { get; set; }
        
        public Address Address { get; set; }
    }

}
