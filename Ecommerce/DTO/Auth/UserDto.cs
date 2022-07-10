using Ecommerce.Models;
using System;
using System.Collections.Generic;

namespace Ecommerce.DTO.Auth
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public string PhotoUrl { get; set; }
        public string KnownAs { get; set; }
        public string Gender { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
