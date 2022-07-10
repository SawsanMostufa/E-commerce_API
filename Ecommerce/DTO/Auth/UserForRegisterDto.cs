using System;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.DTO.Auth
{
    public class UserForRegisterDto
    {
        [Required]
        [StringLength(50, MinimumLength = 3,
       ErrorMessage = "Username must be at least 3 characters long")]
        public string Username { get; set; }
        [Required]
        public string FullName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 4,
        ErrorMessage = "The password must be entered, it must be between 4 and 50 characters")]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        //[Required]
        public string KnownAs { get; set; }
        //[Required]
        public string Mobile { get; set; }

        //[Required]
        public bool IsWhatsup { get; set; }
        //[Required]
        public string Phone { get; set; }
        // [Required]
        public string Address { get; set; }
        //[Required]
        public string Gender { get; set; }

        //[Required]
        public DateTime DateOfBirth { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }

        //public RoleEditDto RoleEditDto { get; set; }
        public UserForRegisterDto()
        {
            Created = DateTime.Now;
            LastActive = DateTime.Now;
        }
    }
}
