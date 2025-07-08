using SharedKernel.DomainEvents;

namespace SharedKernel.Entities.Abstractions;

public interface IEntityDomainEvent
{
    void ClearDomainEvents();
    void Raise(IDomainEvent domainEvent);
    IReadOnlyList<IDomainEvent> DomainEvents { get; }
}
