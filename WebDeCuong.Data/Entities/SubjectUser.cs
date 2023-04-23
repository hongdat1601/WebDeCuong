using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeCuong.Data.Entities
{
    public class SubjectUser
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;
        public ApplicationUser User { get; set; } = null!;

        [Required]
        public string SubjectId { get; set; } = string.Empty;
        public Subject Subject { get; set; } = null!;
    }
}
