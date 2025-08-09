using IntermediateProject.Domain.Abstraction.DomainEvents;

namespace IntermediateProject.Domain.Entities.Customers.Events
{
	public record CustomerCreatedDomainEvent(Guid CustomerId) : IDomainEvent;
}
