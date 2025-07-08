namespace SharedKernel.Entities.Abstractions;

internal interface ISoftDelete
{
    bool IsDeleted { get; set; }
    DateTimeOffset? DeleteAt { get; set; }

    void Restore();
}
