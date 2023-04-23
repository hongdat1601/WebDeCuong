using System.ComponentModel.DataAnnotations;

namespace WebDeCuong.Api.Models
{
    public class SubjectOutputStandardModel
    {
        public int? Id { get; set; }
        public int Clo { get; set; }
        public required string Content { get; set; }
        public required string SoPerPi { get; set; }
    }
}
