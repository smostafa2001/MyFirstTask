using Mostafa.Application.Interfaces.Contexts;
using Mostafa.Common;

namespace Mostafa.Application.Services.Factors.Commands.GetFactor;

public class GetFactorService : IGetFactorService
{
    private readonly IDbContext _context;

    public GetFactorService(IDbContext context) => _context = context;

    public FactorViewModel Get(int id) => _context.Factors.Select(factor => new FactorViewModel
    {
        Id = factor.Id,
        CreationDate = factor.CreationDate.ToFarsi(),
        Description = factor.Description,
        FactorItems = factor.FactorItems,
        IsRemoved = factor.IsRemoved
    }).FirstOrDefault(f => f.Id == id);
}
