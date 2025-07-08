namespace SharedKernel.Entities.Abstractions;

internal interface ITracking<TKey> where TKey : notnull
{
    DateTimeOffset CreatedAt { get; set; }
    TKey CreatedBy { get; set; }
    DateTimeOffset? ModifiedAt { get; set; }
    TKey? ModifiedBy { get; set; }
}
