using System;
namespace WebDeCuong.Api.Models
{
	public class SubjectCurriculumModel
	{
		public string SemesterName { get; set; } = string.Empty;
		public ICollection<string> SubjectId { get; set; } = null!;
	}
}

