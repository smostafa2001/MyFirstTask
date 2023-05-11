using Mostafa.Application.Interfaces.Contexts;
using Mostafa.Application.Services.FactorItems.Commands.EditFactorItem;

namespace Mostafa.Application.Services.FactorItems.Commands.GetFactorItemDetails;

public class GetFactorItemDetailsService : IGetFactorItemDetailsService
{
    private readonly IDbContext _context;

    public GetFactorItemDetailsService(IDbContext context) => _context = context;

    public EditItem GetDetails(int id) => _context.Items.Select(item => new EditItem
    {
        Id = item.Id,
        Discount = item.Discount,
        ProductId = item.ProductId,
        FactorId = item.FactorId,
        Quantity = item.Quantity,
        Tax = item.Tax,
        UnitId = item.UnitId,
        UnitPrice = item.UnitPrice
    }).FirstOrDefault(item => item.Id == id);
}
