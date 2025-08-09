using IntermediateProject.Domain.Abstraction;
using IntermediateProject.Domain.Abstraction.ResultPattern;

namespace IntermediateProject.Domain.Exceptions
{
	public class PayloadFormatException(
	List<string> errors) : Exception, IBadRequest
	{
		public Error Errors { get; set; } = new()
		{
			ErrorCode = "PayloadFormat.Error",
			ErrorMessages = errors
		};
	}
}
