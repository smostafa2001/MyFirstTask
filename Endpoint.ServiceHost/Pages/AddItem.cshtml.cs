using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mostafa.Application.Services.FactorItems.Commands.AddFactorItem;
using Mostafa.Application.Services.Products.Queries.GetProducts;
using Mostafa.Application.Services.Units.Queries.GetUnits;

namespace Endpoint.ServiceHost.Pages;

public class AddItemModel : PageModel
{
    private readonly IGetProductsService _getProductsService;
    private readonly IGetUnitsService _getUnitsService;
    private readonly IAddFactorItemService _addFactorItemService;

    public SelectList Products { get; set; }
    public SelectList Units { get; set; }
    public AddItem Command { get; set; }
    public int FactorId { get; private set; }
    public AddItemModel(IGetProductsService getProductsService, IAddFactorItemService addFactorItemService, IGetUnitsService getUnitsService)
    {
        _getProductsService = getProductsService;
        _addFactorItemService = addFactorItemService;
        _getUnitsService = getUnitsService;
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
        return RedirectToPage("./Items", new { Id = command.FactorId });
    }
}
