using Mostafa.Application.Interfaces.Contexts;
using Mostafa.Application.Services.Factors.Commands.EditFactors;

namespace Mostafa.Application.Services.Factors.Commands.GetFactorDetails;

public class GetFactorDetailsService : IGetFactorDetailsService
{
    private readonly IDbContext _context;

    public GetFactorDetailsService(IDbContext context) => _context = context;

    public EditFactor GetDetails(int id) => _context.Factors.Select(factor => new EditFactor
    {
        Id = factor.Id,
        CreationDate = factor.CreationDate,
        Description = factor.Description
    }).FirstOrDefault(factor => factor.Id == id);
}
