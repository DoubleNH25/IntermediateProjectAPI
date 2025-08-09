using System.ComponentModel.DataAnnotations;

namespace IntermediateProject.Domain.Entities.Identity.Users.DTOs
{
	public class RevokeUserDto
	{
		[Required]
		[MaxLength(256)]
		[EmailAddress]
		public string Email { get; set; } = null!;
	}
}
