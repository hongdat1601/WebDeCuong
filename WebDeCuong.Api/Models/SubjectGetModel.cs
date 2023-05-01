namespace WebDeCuong.Api.Models
{
    public class SubjectGetModel
    {
        public required string Id { get; set; }
        public required string Name { get; set; }

        public int TotalCredits { get; set; }

        public string? RequestUserMail { get; set; }
    }
}
