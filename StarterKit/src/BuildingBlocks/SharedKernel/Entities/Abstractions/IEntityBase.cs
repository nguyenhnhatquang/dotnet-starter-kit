namespace SharedKernel.Entities.Abstractions;

internal interface IEntityBase<out TKey> where TKey : notnull
{
    TKey Id { get; }
}
