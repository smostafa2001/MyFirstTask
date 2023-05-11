using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mostafa.Application.Services.FactorItems.Commands.RemoveFactorItem;
using Mostafa.Application.Services.FactorItems.Queries.GetFactorItems;
using Mostafa.Application.Services.Factors.Commands.GetFactor;

namespace Endpoint.ServiceHost.Pages;

public class ItemsModel : PageModel
{
    public List<FactorItemQueryModel> Items { get; set; }
    public FactorViewModel Factor { get; set; }
    public int Id { get; private set; }
    private readonly IGetFactorItemsService _getFactorItemsService;
    private readonly IGetFactorService _getFactorService;
    private readonly IRemoveFactorItemService _removeFactorItemService;

    public ItemsModel(IGetFactorItemsService getFactorItemsService, IGetFactorService getFactorService, IRemoveFactorItemService removeFactorItemService)
    {
        _getFactorItemsService = getFactorItemsService;
        _getFactorService = getFactorService;
        _removeFactorItemService = removeFactorItemService;
    }

    public void OnGet(int id)
    {
        Id = id;
        Items = _getFactorItemsService.GetItems(id);
        Factor = _getFactorService.Get(id);
    }

    public IActionResult OnPostRemove(int id, int factorId)
    {
        _removeFactorItemService.Remove(id);
        return RedirectToPage("/Items", new { Id = factorId });
    }
}
