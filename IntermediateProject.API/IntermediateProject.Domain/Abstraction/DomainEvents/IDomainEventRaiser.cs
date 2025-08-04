namespace IntermediateProject.Domain.Abstraction.DomainEvents
{
	public interface IDomainEventRaiser
	{
		IReadOnlyList<IDomainEvent> GetDomainEvents();
		void ClearDomainEvents();
		void RaiseDomainEvent(IDomainEvent domainEvent);
	}
}
