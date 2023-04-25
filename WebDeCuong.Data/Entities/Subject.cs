using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeCuong.Data.Entities
{
    public class Subject
    {
        [Key]
        public string Id { get; set; } = string.Empty;

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int TheoryCredits { get; set; }

        [Required]
        public int PracticeCredits { get; set; }

        [Required]
        public int SelfLearningCredits { get; set; }

        [Required]
        public int TotalCredits { get; set; }

        [Column(TypeName = "text")]
        public string Teachers { get; set; } = string.Empty;

        [Column(TypeName = "text")]
        public string? Documents { get; set; }

        [Required]
        [Column(TypeName = "text")]
        public string Goals { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "text")]
        public string Abstract { get; set; } = string.Empty;


        public string? A { get; set; }
        public string? B { get; set; }
        public string? C { get; set; }

        [Column(TypeName = "text")]
        public string? Other { get; set; }

        public ICollection<EvalElement> EvalElements { get; set; } = null!;
        public ICollection<Evaluate> Evaluates { get; set; } = null!;
        public ICollection<SubjectContent> SubjectContents { get; set; } = null!;
        public ICollection<SubjectOutputStandard> SubjectOutputStandards { get; set; } = null!;
        public ICollection<SubjectUser> SubjectUsers { get; set; } = null!;
        public ICollection<SubjectCurriculum> SubjectCurriculum { get; set; } = null!;
     }
}
