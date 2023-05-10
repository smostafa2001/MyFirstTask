using Microsoft.EntityFrameworkCore;
using Mostafa.Application.Interfaces.Contexts;
using Mostafa.Domain.Entities.Factors;
using Mostafa.Domain.Entities.Products;
using Mostafa.Domain.Entities.Units;
using Mostafa.Persistence.Mappings;

namespace Mostafa.Persistence;
public class MostafaDbContext : DbContext, IDbContext
{
    public DbSet<Factor> Factors { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Unit> Units { get; set; }
    public MostafaDbContext(DbContextOptions options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(FactorMapping).Assembly);
}
