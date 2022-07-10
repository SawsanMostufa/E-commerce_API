using System.ComponentModel.DataAnnotations;

namespace Ecommerce.DTO.Auth
{
    public class UserForLoginDto
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must be at least 3 characters and not more than 50 characters long")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The password must be entered, it must be between 4 and 50 characters")]

        public string Password { get; set; }
    }
}
