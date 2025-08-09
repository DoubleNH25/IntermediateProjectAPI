﻿
using System.ComponentModel.DataAnnotations;

namespace IntermediateProject.Domain.Entities.Identity.Users.DTOs
{
	public class RefreshTokenDto
	{
		[Required]
		public string AccessToken { get; set; } = null!;

		[Required]
		public string RefreshToken { get; set; } = null!;
	}

}
