using Mostafa.Domain.Entities.Products;

namespace Mostafa.Application.Services.Products.Queries.GetProducts;
public interface IGetProductsService
{
    List<Product> Products(int factorId);
}
