using IntermediateProject.Domain.Abstraction;
using IntermediateProject.Domain.Abstraction.ResultPattern;

namespace IntermediateProject.Domain.Exceptions
{
	public class UserAlreadyExistException(
	List<string> errors) : Exception, IBadRequest
	{
		public Error Errors { get; set; } = new()
		{
			ErrorCode = "DuplicateUser.Error",
			ErrorMessages = errors
		};
	}
}
