using Mostafa.Application.Interfaces.Contexts;
using Mostafa.Domain.Entities.Units;

namespace Mostafa.Application.Services.Units.Queries.GetUnits;

public class GetUnitsService : IGetUnitsService
{
    private readonly IDbContext _context;
    public GetUnitsService(IDbContext context) => _context = context;
    public List<Unit> Units => _context.Units.ToList();
}
