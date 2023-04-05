using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeCuong.Data.Entities
{
    public class Evaluate
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CloName { get; set; } = string.Empty;

        [Required]
        public string Test { get; set; } = string.Empty;

        [Required]
        public string Method { get; set; } = string.Empty;

        [Required]
        public float Proportion { get; set; }

        [Required]
        public string Target { get; set; } = string.Empty;

        [Required]
        public int SubjectId { get; set; }
        public Subject Subject { get; set; } = null!;
    }
}
