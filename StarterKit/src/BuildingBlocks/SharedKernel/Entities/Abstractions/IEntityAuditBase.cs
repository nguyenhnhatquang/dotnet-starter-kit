namespace SharedKernel.Entities.Abstractions;

internal interface IEntityAuditBase<TKey, TUKey> : IEntityBase<TKey>, ITracking<TUKey>, ISoftDelete
    where TKey : notnull 
    where TUKey : notnull
{

}
