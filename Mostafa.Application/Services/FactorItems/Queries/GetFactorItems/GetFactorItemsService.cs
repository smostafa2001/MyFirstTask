using Mostafa.Application.Interfaces.Contexts;

namespace Mostafa.Application.Services.FactorItems.Queries.GetFactorItems;

public class GetFactorItemsService : IGetFactorItemsService
{
    private readonly IDbContext _context;

    public GetFactorItemsService(IDbContext context) => _context = context;

    public List<FactorItemQueryModel> GetItems(int id) => _context.Items.Where(i => i.FactorId == id).Select(item => new FactorItemQueryModel
    {
        Id = item.Id,
        Product = item.Product.Name,
        Unit = item.Unit.Name,
        Quantity = item.Quantity,
        Tax = item.Tax,
        UnitPrice = item.UnitPrice,
        Discount = item.Discount,
        FactorId = item.FactorId
    }).ToList();
}
