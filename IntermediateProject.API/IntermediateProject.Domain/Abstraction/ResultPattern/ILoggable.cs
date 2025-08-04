using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IntermediateProject.Domain.Abstraction.ResultPattern
{
	public interface ILoggable
	{
		bool IsNotSuccessfull { get; set; }
		Error? Errors { get; set; }
	}
}
