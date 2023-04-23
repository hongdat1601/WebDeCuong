using System.ComponentModel.DataAnnotations;

namespace WebDeCuong.Api.Models
{
    public class EvaluateModel
    {
        public int? Id { get; set; }
        public int Order { get; set; }
        public int Clo { get; set; }
        public required string Test { get; set; }
        public required string Method { get; set; }
        public int Proportion { get; set; }
        public int Target { get; set; }
    }
}
