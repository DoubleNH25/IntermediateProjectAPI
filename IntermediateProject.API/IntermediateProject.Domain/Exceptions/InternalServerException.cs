using IntermediateProject.Domain.Abstraction;
using IntermediateProject.Domain.Abstraction.ResultPattern;

namespace IntermediateProject.Domain.Exceptions
{
	public class InternalServerException(
	string errorCode,
	List<string> errors) : Exception, IINternalServerError
	{
		public Error Errors { get; set; } = new()
		{
			ErrorCode = errorCode,
			ErrorMessages = errors
		};
	}

}
