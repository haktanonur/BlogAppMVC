using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "E-Mail")]
        public string? Email { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Maximum ten characters!")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}