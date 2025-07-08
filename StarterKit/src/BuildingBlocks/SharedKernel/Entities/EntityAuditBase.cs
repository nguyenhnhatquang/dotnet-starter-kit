using SharedKernel.Entities.Abstractions;

namespace SharedKernel.Entities;

public abstract class EntityAuditBase<TKey, TUKey> : EntityBase<TKey>, IEntityAuditBase<TKey, TUKey>
    where TKey : notnull
    where TUKey : notnull
{
    public DateTimeOffset CreatedAt { get; set; }
    public TUKey CreatedBy { get; set; }
    public DateTimeOffset? ModifiedAt { get; set; }
    public TUKey? ModifiedBy { get; set; }
    public bool IsDeleted { get; set; }
    public DateTimeOffset? DeleteAt { get; set; }

    public void Restore()
    {
        IsDeleted = false;
        DeleteAt = null;
    }
}
