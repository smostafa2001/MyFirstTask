using Mostafa.Application.Interfaces.Contexts;
using Mostafa.Domain.Entities.Products;

namespace Mostafa.Application.Services.Products.Queries.GetProducts;

public class GetProductsService : IGetProductsService
{
    private readonly IDbContext _context;

    public GetProductsService(IDbContext context) => _context = context;

    public List<Product> Products(int factorId)
    {
        var factorItems = _context.Items.Where(item => item.FactorId == factorId).ToList();
        var products = _context.Products.ToList();
        foreach (var item in factorItems)
        {
            if (products.Contains(item.Product)) products.Remove(item.Product);
        }

        return products;
    }
}