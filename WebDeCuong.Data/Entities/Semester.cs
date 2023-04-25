using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
namespace WebDeCuong.Data.Entities
{
	public class Semester
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; } = null!;

		public ICollection<SubjectCurriculum> SubjectCurriculum { get; set; } = null!;
	}
}

