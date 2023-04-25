using System;
namespace WebDeCuong.Api.Models
{
	public class SubjectCurriculumModel
	{
		public string name { get; set; }
		public ICollection<string> SubjectId { get; set; }
	}
}

