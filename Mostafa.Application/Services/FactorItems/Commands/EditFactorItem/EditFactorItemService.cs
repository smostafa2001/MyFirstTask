using Mostafa.Application.Interfaces.Contexts;
using Mostafa.Domain.Entities.Factors;

namespace Mostafa.Application.Services.FactorItems.Commands.EditFactorItem;

public class EditFactorItemService : IEditFactorItemService
{
    private readonly IDbContext _context;

    public EditFactorItemService(IDbContext context) => _context = context;

    public void Edit(EditItem command)
    {
        FactorItem item = _context.Items.FirstOrDefault(i => i.Id == command.Id);
        item.Edit(command.ProductId, command.UnitId, command.Quantity, command.Tax, command.UnitPrice, command.Discount, command.FactorId);
        _context.SaveChanges();
    }
}
