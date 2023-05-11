using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mostafa.Application.Services.FactorItems.Commands.EditFactorItem;
using Mostafa.Application.Services.FactorItems.Commands.GetFactorItemDetails;
using Mostafa.Application.Services.Products.Queries.GetProduct;
using Mostafa.Application.Services.Products.Queries.GetProducts;
using Mostafa.Application.Services.Units.Queries.GetUnits;
using Mostafa.Domain.Entities.Products;

namespace Endpoint.ServiceHost.Pages;

public class EditItemModel : PageModel
{
    private readonly IGetProductsService _getProductsService;
    private readonly IGetUnitsService _getUnitsService;
    private readonly IEditFactorItemService _editFactorItemService;
    private readonly IGetFactorItemDetailsService _getFactorItemDetailsService;
    private readonly IGetProductService _getProductService;
    public Product Product { get; set; }
    public SelectList Products { get; set; }
    public SelectList Units { get; set; }
    public EditItem Command { get; set; }
    public int FactorId { get; set; }

    public EditItemModel(IGetProductsService getProductsService, IGetUnitsService getUnitsService, IEditFactorItemService editFactorItemService, IGetFactorItemDetailsService getFactorItemDetailsService, IGetProductService getProductService)
    {
        _getProductsService = getProductsService;
        _getUnitsService = getUnitsService;
        _editFactorItemService = editFactorItemService;
        _getFactorItemDetailsService = getFactorItemDetailsService;
        _getProductService = getProductService;
    }

    public void OnGet(int id)
    {
        Command = _getFactorItemDetailsService.GetDetails(id);
        FactorId = Command.FactorId;
        Product = _getProductService.GetProduct(Command.ProductId);
        Products = new SelectList(_getProductsService.Products(FactorId), "Id", "Name");
        Units = new SelectList(_getUnitsService.Units, "Id", "Name");
    }

    public IActionResult OnPost(EditItem command)
    {
        _editFactorItemService.Edit(command);
        return RedirectToPage("./Items", new { Id = command.FactorId });
    }
}
