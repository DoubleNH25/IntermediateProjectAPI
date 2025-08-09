using IntermediateProject.Domain.Abstraction;
using IntermediateProject.Domain.Abstraction.ResultPattern;

namespace IntermediateProject.Domain.Exceptions
{
	public class InvalidTokenException(
	List<string> errors) : Exception, IBadRequest
	{
		public Error Errors { get; set; } = new()
		{
			ErrorCode = "InvalidToken.Error",
			ErrorMessages = errors
		};
	}
}
