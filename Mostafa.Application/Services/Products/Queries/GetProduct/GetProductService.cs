using Mostafa.Application.Interfaces.Contexts;
using Mostafa.Domain.Entities.Products;

namespace Mostafa.Application.Services.Products.Queries.GetProduct;

public class GetProductService : IGetProductService
{
    private readonly IDbContext _context;

    public GetProductService(IDbContext context) => _context = context;

    public Product GetProduct(int id) => _context.Products.FirstOrDefault(product => product.Id == id);
}
