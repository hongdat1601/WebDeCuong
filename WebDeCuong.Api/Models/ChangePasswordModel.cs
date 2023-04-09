namespace WebDeCuong.Api.Models
{
    public class ChangePasswordModel
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string NewPassword { get; set; }
    }
}
