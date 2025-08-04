using IntermediateProject.Domain.Abstraction.ResultPattern;

namespace IntermediateProject.Domain.Abstraction
{
	public interface IBadRequest
	{
		public Error Errors { get; set; }
	}
}
