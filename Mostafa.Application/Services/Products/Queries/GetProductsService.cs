using Mostafa.Application.Interfaces.Contexts;

namespace Mostafa.Application.Services.Products.Queries;

public class GetProductsService : IGetProductsService
{
    private readonly IDbContext _context;

    public GetProductsService(IDbContext context)
    {
        _context = context;
    }

    public List<ProductQueryModel> Products(int factorId) => _context.Products.Select(product => new ProductQueryModel { Id = product.Id, Name = product.Name }).ToList();
}