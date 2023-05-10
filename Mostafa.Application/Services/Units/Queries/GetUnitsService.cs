using Mostafa.Application.Interfaces.Contexts;

namespace Mostafa.Application.Services.Units.Queries;

public class GetUnitsService : IGetUnitsService
{
	private readonly IDbContext _context;
	public GetUnitsService(IDbContext context) => _context = context;
	public List<UnitQueryModel> Units => _context.Units.Select(unit => new UnitQueryModel { Id = unit.Id, Name = unit.Name }).ToList();
}
