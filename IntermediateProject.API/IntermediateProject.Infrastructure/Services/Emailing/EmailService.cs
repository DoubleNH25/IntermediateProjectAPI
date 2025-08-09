using IntermediateProject.Application.Abstraction.Emailing;

namespace IntermediateProject.Infrastructure.Services.Emailing
{
	public class EmailService : IEmailService
	{
		public Task SendAsync()
		{
			return Task.CompletedTask;
		}
	}

}
