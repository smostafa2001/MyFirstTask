using Mostafa.Application.Interfaces.Contexts;
using Mostafa.Domain.Entities.Factors;

namespace Mostafa.Application.Services.FactorItems.Commands.AddFactorItem;

public class AddFactorItemService : IAddFactorItemService
{
    private readonly IDbContext _context;

    public AddFactorItemService(IDbContext context) => _context = context;

    public void AddItem(AddItem command)
    {
        var item = new FactorItem(command.ProductId, command.UnitId, command.Quantity, command.Tax, command.UnitPrice, command.Discount, command.FactorId);
        _context.Items.Add(item);
        _context.SaveChanges();
    }
}
