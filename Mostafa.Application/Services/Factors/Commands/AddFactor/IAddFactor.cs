using Mostafa.Application.Interfaces.Contexts;
using Mostafa.Domain.Entities.Factors;

namespace Mostafa.Application.Services.Factors.Commands.AddFactor;
public interface IAddFactorService
{
    void Add(string description);
}

public class AddFactorService : IAddFactorService
{
    private readonly IDbContext _context;

    public AddFactorService(IDbContext context) => _context = context;

    public void Add(string description)
    {
        Factor factor = new(description);
        _context.Factors.Add(factor);
    }
}
