using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeCuong.Data.Entities
{
    public class SubjectOutputStandard
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Clo { get; set; }

        [Required]
        [Column(TypeName = "text")]
        public string Content { get; set; } = string.Empty;

        [Required]
        public string SoPerPi { get; set; } = string.Empty;

        [Required]
        public string SubjectId { get; set; } = string.Empty;
        public Subject Subject { get; set; } = null!;
    }
}
