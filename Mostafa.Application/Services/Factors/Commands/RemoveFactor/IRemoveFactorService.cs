using Mostafa.Application.Interfaces.Contexts;

namespace Mostafa.Application.Services.Factors.Commands.RemoveFactor;
public interface IRemoveFactorService
{
    void Remove(int id);
}

public class RemoveFactorService : IRemoveFactorService
{
    private readonly IDbContext _context;

    public RemoveFactorService(IDbContext context) => _context = context;

    public void Remove(int id)
    {
        var factor = _context.Factors.FirstOrDefault(f => f.Id == id);
        factor.Remove();
        _context.SaveChanges();
    }
}
