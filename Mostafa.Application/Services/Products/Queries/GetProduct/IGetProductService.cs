using Mostafa.Domain.Entities.Products;

namespace Mostafa.Application.Services.Products.Queries.GetProduct;
public interface IGetProductService
{
    Product GetProduct(int id);
}
