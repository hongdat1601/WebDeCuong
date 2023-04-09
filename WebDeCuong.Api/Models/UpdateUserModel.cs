namespace WebDeCuong.Api.Models
{
    public class UpdateUserModel
    {
        public required string Email { get; set; }
        public required string FullName { get; set; }
        public required string Faculty { get; set; }
        public required string Phone { get; set; }
        public required string PlaceOfBirth { get; set; }
        public required string DateOfBirth { get; set; }
        public required bool Gender { get; set; }
    }
}
