using Mostafa.Application.Services.FactorItems.Commands.EditFactorItem;

namespace Mostafa.Application.Services.FactorItems.Commands.GetFactorItemDetails;
public interface IGetFactorItemDetailsService
{
    EditItem GetDetails(int id);
}
