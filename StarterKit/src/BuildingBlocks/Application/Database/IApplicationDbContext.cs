using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Application.Database;

public interface IApplicationDbContext
{
    EntityEntry Entry(object entity);
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
