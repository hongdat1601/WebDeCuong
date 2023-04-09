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

        public List<string> CloName { get; set; } 
        public List<string> OutputContent { get; set; } 
        public List<string> SoPerPi { get; set; }

        public List<string> Content { get; set; } 
        public List<int> NLessons { get; set; }
        public List<string> Clos { get; set; } 
        public List<string> Method { get; set; }
        public List<string>? Bonus { get; set; }

        public List<string> EvaluateCloName { get; set; }
        public List<string> Test { get; set; }
        public List<string> EvaluateMethod { get; set; }
        public List<float> EvalPropotion { get; set; }
        public List<string> Target { get; set; }

        public List<string> EvaluaElementName { get; set; }
        public List<string> EvaluaElementMethod { get; set; }
        public List<float> EvaluaElementPropotion { get; set; }

        public List<string> UserId { get; set; } = null!;
    }
}

