namespace Mostafa.Application.Services.FactorItems.Queries.GetFactorItems;
public interface IGetFactorItemsService
{
    List<FactorItemQueryModel> GetItems(int id);
}
