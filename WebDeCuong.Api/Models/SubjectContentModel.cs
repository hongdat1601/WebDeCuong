using System.ComponentModel.DataAnnotations;

namespace WebDeCuong.Api.Models
{
    public class SubjectContentModel
    {
        public int? Id { get; set; }
        public int Order { get; set; }
        public required string Content { get; set; }
        public int NLessons { get; set; }
        public required string Clos { get; set; }
        public required string Method { get; set; }
        public string? Bonus { get; set; }
    }
}
