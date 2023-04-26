using System;
namespace WebDeCuong.Api.Models
{
	public class CurriculumModel
	{
		public int? Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public ICollection<SubjectCurriculumModel> subjectCurriculumModels { get; set; } = null!;
	}
}

