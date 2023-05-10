using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostafa.Application.Services.Products.Queries;
public interface IGetProductsService
{
    List<ProductQueryModel> Products(int factorId);
}
