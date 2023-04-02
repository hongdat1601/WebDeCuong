using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebDeCuong.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required]
        public string Avatar { get; set; } = string.Empty;

        [Required]
        public string Faculty { get; set; } = string.Empty;
    }
}
