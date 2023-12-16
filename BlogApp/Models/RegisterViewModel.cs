using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class RegisterViewModel
    {

        [Required]
        [Display(Name = "Username")]
        public string? UserName { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "E-Mail")]
        public string? Email { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Maximum ten characters!")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Passwords do not match!")]
        [Display(Name = "Confirm Password")]
        public string? ConfirmPassword { get; set; }
    }
}