using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mostafa.Application.Services.FactorItems.Commands.AddFactorItem;
using Mostafa.Application.Services.Factors.Commands.GetFactor;
using Mostafa.Application.Services.Products.Queries;
using Mostafa.Application.Services.Units.Queries;

namespace Endpoint.ServiceHost.Pages;

public class AddItemModel : PageModel
{
    private readonly IGetProductsService _getProductsService;
    private readonly IGetUnitsService _getUnitsService;
    private readonly IAddFactorItemService _addFactorItemService;
    private readonly IGetFactorService _getFactorService;

    public SelectList Products { get; set; }
    public SelectList Units { get; set; }
    public AddItem Command { get; set; }
    public int FactorId { get; private set; }
    public AddItemModel(IGetProductsService getProductsService, IAddFactorItemService addFactorItemService, IGetUnitsService getUnitsService, IGetFactorService getFactorService)
    {
        _getProductsService = getProductsService;
        _addFactorItemService = addFactorItemService;
        _getUnitsService = getUnitsService;
        _getFactorService = getFactorService;
    }

    public void OnGet(int id)
    {
        FactorId = id;
        Products = new SelectList(_getProductsService.Products(id), "Id", "Name");
        Units = new SelectList(_getUnitsService.Units, "Id", "Name");
    }

    public IActionResult OnPost(AddItem command)
    {
        _addFactorItemService.AddItem(command);
        FactorId = command.FactorId;
        return RedirectToPage("./Items", new { Id = FactorId });
    }
}
