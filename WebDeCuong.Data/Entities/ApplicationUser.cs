using Microsoft.AspNetCore.Identity;

namespace WebDeCuong.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; } 
        public string Avatar { get; set; }
        public string Faculty { get; set; }
    }
}
