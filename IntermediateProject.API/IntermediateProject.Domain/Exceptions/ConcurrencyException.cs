using IntermediateProject.Domain.Abstraction;
using IntermediateProject.Domain.Abstraction.ResultPattern;

namespace IntermediateProject.Domain.Exceptions
{
	public class ConcurrencyException(
	List<string> errors) : Exception, IBadRequest
	{
		public Error Errors { get; set; } = new()
		{
			ErrorCode = "Concurrency.Error",
			ErrorMessages = errors
		};
	}
}
