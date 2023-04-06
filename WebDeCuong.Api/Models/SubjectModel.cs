using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using WebDeCuong.Data.Entities;

namespace WebDeCuong.Api.Models
{
	public class SubjectModel
	{
        public string Name { get; set; } 

        public int TheoryCredits { get; set; }

        public int PracticeCredits { get; set; }

  
        public int TotalCredits { get; set; }

   
        public string? Documents { get; set; }

  
        public string Goals { get; set; } = string.Empty;

       
        public string Abstract { get; set; } = string.Empty;


        public string? A { get; set; }
        public string? B { get; set; }
        public string? C { get; set; }

        public string? Other { get; set; }
        public List<string> UserId { get; set; } = null!;
    }
}

