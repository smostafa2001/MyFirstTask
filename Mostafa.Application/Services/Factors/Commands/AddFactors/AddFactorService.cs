using Mostafa.Application.Interfaces.Contexts;
using Mostafa.Domain.Entities.Factors;

namespace Mostafa.Application.Services.Factors.Commands.AddFactors;

public class AddFactorService : IAddFactorService
{
    private readonly IDbContext _context;

    public AddFactorService(IDbContext context) => _context = context;

    public int Add(AddFactor command)
    {
        Factor factor = new(command.Description, command.CreationDate);
        _context.Factors.Add(factor);
        _context.SaveChanges();
        return factor.Id;
    }
}
