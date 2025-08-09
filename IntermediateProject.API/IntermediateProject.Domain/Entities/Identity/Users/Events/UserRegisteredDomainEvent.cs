using IntermediateProject.Domain.Abstraction.DomainEvents;

namespace IntermediateProject.Domain.Entities.Identity.Users.Events
{
	public record UserRegisteredDomainEvent(
	Guid UserId,
	string? AdminKey) : IDomainEvent;

}
