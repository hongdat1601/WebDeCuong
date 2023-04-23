using System.ComponentModel.DataAnnotations;

namespace WebDeCuong.Api.Models
{
    public class EvalElementModel
    {
        public int? Id { get; set; }
        public int Order { get; set; }
        public required string Name { get; set; }
        public required string Method { get; set; }
        public int Proportion { get; set; }
    }
}
