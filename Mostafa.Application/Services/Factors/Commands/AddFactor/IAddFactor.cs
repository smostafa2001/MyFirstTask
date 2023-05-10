using Mostafa.Application.Interfaces.Contexts;

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
        
    }
}
