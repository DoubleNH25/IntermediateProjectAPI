using IntermediateProject.Domain.Abstraction.ResultPattern;
namespace IntermediateProject.Domain.Abstraction
{
	public interface IINternalServerError
	{
		public Error Errors { get; set; }
	}
}
