using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace WebDeCuong.Data.Entities
{
	public class SubjectCurriculum
	{
        [Key]
        public int Id { get; set; }

        [Required]
        public int CurriculumId { get; set; } 
        public Curriculum Curriculum { get; set; } = null!;

        [Required]
        public string SubjectId { get; set; } = string.Empty;
        public Subject Subject { get; set; } = null!;

        [Required]
        public int SemesterId { get; set; }
        public Semester Semester { get; set; } = null!;
    }
}

