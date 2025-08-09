using IntermediateProject.Domain.Abstraction.DomainEvents;
namespace IntermediateProject.Domain.Entities.Invoices.Events
{
	public record InvoiceCreatedDomainEvent(
	Guid InvoiceId) : IDomainEvent;
}
