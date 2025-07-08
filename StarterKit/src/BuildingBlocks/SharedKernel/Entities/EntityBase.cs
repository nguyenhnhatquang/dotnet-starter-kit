using System.ComponentModel.DataAnnotations;
using SharedKernel.DomainEvents;
using SharedKernel.Entities.Abstractions;

namespace SharedKernel.Entities;

public abstract class EntityBase<TKey> : IEntityBase<TKey>, IEntityDomainEvent
    where TKey : notnull
{
    [Key]
    public TKey Id { get; set; }

    private readonly List<IDomainEvent> _domainEvents = [];

    public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }

    public void Raise(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
}
