using Microsoft.AspNetCore.Mvc.RazorPages;
using Mostafa.Application.Services.FactorItems.Queries.GetFactorItems;
using Mostafa.Application.Services.Factors.Commands.GetFactor;
using Mostafa.Application.Services.Factors.Queries.GetFactors;

namespace Endpoint.ServiceHost.Pages;

public class ItemsModel : PageModel
{
    public List<FactorItemQueryModel> Items { get; set; }
    public FactorViewModel Factor { get; set; }
    public int Id { get; private set; }
    private readonly IGetFactorItemsService _getFactorItemsService;
    private readonly IGetFactorService _getFactorService;

    public ItemsModel(IGetFactorItemsService getFactorItemsService, IGetFactorService getFactorService)
    {
        _getFactorItemsService = getFactorItemsService;
        _getFactorService = getFactorService;
    }

    public void OnGet(int id)
    {
        Id = id;
        Items = _getFactorItemsService.GetItems(id);
        Factor = _getFactorService.Get(id);
    }
}
