using Microsoft.EntityFrameworkCore;
using Mostafa.Application.Interfaces.Contexts;
using Mostafa.Domain.Entities.Factors;
using Mostafa.Domain.Entities.Products;
using Mostafa.Domain.Entities.Units;

namespace Mostafa.Persistence;
public class MostafaDbContext : DbContext, IDbContext
{
    public DbSet<Factor> Factors { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Unit> Units { get; set; }
    public DbSet<FactorItem> Items { get; set; }

    public MostafaDbContext(DbContextOptions options) : base(options) { }
}
