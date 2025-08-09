using IntermediateProject.Domain.Abstraction.DomainEvents;
using IntermediateProject.Domain.Entities.Shared;
namespace IntermediateProject.Domain.Entities.Invoices.Events
{
	public record InvoiceRemovedDomainEvent(
		Guid CustomerId,
		Money InvoiceValue) : IDomainEvent;
}
