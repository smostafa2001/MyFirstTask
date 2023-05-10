using Mostafa.Application.Interfaces.Contexts;

namespace Mostafa.Application.Services.Factors.Queries.GetFactors;
public interface IGetFactorsService
{
    List<FactorQueryModel> GetFactors();
}

public class GetFactorsService : IGetFactorsService
{
    private readonly IDbContext _context;

    public GetFactorsService(IDbContext context) => _context = context;

    public List<FactorQueryModel> GetFactors() => _context.Factors
        .Where(factor => !factor.IsRemoved)
        .Select(factor => new FactorQueryModel
        {
            Id = factor.Id,
            CreationDate = factor.CreationDate,
            Description = factor.Description,
            IsRemoved = factor.IsRemoved,
        }).ToList();
}
