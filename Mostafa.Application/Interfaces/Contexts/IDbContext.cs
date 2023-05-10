using Microsoft.EntityFrameworkCore;
using Mostafa.Domain.Entities.Factors;
using Mostafa.Domain.Entities.Products;
using Mostafa.Domain.Entities.Units;

namespace Mostafa.Application.Interfaces.Contexts;
public interface IDbContext
{
    DbSet<Factor> Factors { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Unit> Units { get; set; }
    int SaveChanges(bool acceptAllChangesOnSuccess);
    int SaveChanges();
    Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
}
