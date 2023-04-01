using System;
namespace WebDeCuong.Api.Models
{
	public class UserModel
	{	public string ID { get; set; }
		public string Username { get; set; }
		public string NormalizedUsername { get; set; }
		public string Email { get; set; }
		public string NormalizedEmail { get; set; }
		public Boolean EmailConfirmed { get; set; }
		public string PassWordHash { get; set; }
		public string SecurityStamp { get; set; }
		public string ConcurencyStamp { get; set; }
        public string PhoneNumber { get; set; }
		public Boolean PhoneNumberConfirm { get; set; }
		public Boolean TwoFactorEnable { get; set; }
		public DateTime LockoutEnd { get; set; }
		public Boolean LockoutEndEnable { get; set; }
		public int AccessFailCount { get; set; }
		public string Avatar { get; set; }
		public string Faculty { get; set; }
		public string FullName { get; set; }

    }
}

