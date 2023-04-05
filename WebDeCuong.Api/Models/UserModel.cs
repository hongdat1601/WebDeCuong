using System;
using System.ComponentModel.DataAnnotations;

namespace WebDeCuong.Api.Models
{
	public class UserModel
	{
		public string? Username { get; set; }
		public string Email { get; set; }
        public string PhoneNumber { get; set; }
		public string Faculty { get; set; }
		public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public string PlaceOfBirth { get; set; } 
    }
}

