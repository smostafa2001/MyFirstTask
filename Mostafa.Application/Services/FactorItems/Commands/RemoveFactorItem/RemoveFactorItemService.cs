using Mostafa.Application.Interfaces.Contexts;
using Mostafa.Domain.Entities.Factors;

namespace Mostafa.Application.Services.FactorItems.Commands.RemoveFactorItem;

public class RemoveFactorItemService : IRemoveFactorItemService
{
    private readonly IDbContext _context;

    public RemoveFactorItemService(IDbContext context) => _context = context;

    public void Remove(int id)
    {
        FactorItem item = _context.Items.FirstOrDefault(i => i.Id == id);
        _context.Items.Remove(item);
        _context.SaveChanges();
    }
}
