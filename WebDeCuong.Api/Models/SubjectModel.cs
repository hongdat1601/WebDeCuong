

namespace WebDeCuong.Api.Models
{
	public class SubjectModel
	{
        public string? Id { get; set; }

        public required string Name { get; set; } 

        public int TheoryCredits { get; set; }

        public int PracticeCredits { get; set; }

        public int SelfLearningCredits { get; set; }

        public int TotalCredits { get; set; }

        public required string Teachers { get; set; }

        public string? Documents { get; set; }

        public required string Goals { get; set; }
       
        public required string Abstract { get; set; }

        public string? A { get; set; }
        public string? B { get; set; }
        public string? C { get; set; }

        public string? Other { get; set; }

        public List<SubjectContentModel> SubjectContents { get; set; } = null!;
        public List<SubjectOutputStandardModel> SubjectOutputStandards { get; set; } = null!;
        public List<EvalElementModel> EvalElements { get; set; } = null!;
        public List<EvaluateModel> Evaluates { get; set; } = null!;
    }
}

