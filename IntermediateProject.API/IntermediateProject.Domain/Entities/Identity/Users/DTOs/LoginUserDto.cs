using System.ComponentModel.DataAnnotations;

namespace IntermediateProject.Domain.Entities.Identity.Users.DTOs
{
	public class LoginUserDto
	{
		[Required]
		[MaxLength(256)]
		[EmailAddress]
		public string Email { get; set; } = null!;

		[Required]
		public string Password { get; set; } = null!;
	}
}
