﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeCuong.Data.Entities
{
    public class SubjectContent
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Order { get; set; }

        [Required]
        [Column(TypeName = "ntext")]
        public string Content { get; set; } = string.Empty;

        [Required]
        public int NLessons { get; set; }

        [Required]
        public string Clos { get; set; } = string.Empty;

        [Required]
        public string Method { get; set; } = string.Empty;

        [Column(TypeName = "ntext")]
        public string? Bonus { get; set; }

        [Required]
        public string SubjectId { get; set; } = string.Empty;
        public Subject Subject { get; set; } = null!;

    }
}
