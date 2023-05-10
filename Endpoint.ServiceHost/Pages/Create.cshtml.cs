using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mostafa.Application.Services.FactorItems.Commands.AddFactorItem;
using Mostafa.Application.Services.Factors.Commands.AddFactor;
using Mostafa.Application.Services.Factors.Commands.GetFactor;
using Mostafa.Application.Services.Products.Queries;
using Mostafa.Application.Services.Units.Queries;

namespace Endpoint.ServiceHost.Pages;

public class CreateModel : PageModel
{
	private readonly IGetProductsService _getProductsService;
	private readonly IGetUnitsService _getUnitsService;
	private readonly IAddFactorItemService _addFactorItemService;
	private readonly IGetFactorService _getFactorService;
	private readonly IAddFactorService _addFactorService;
	public SelectList Products { get; set; }
	public SelectList Units { get; set; }
	public AddFactor AddFactorCommand { get; set; }
	public AddItem AddItemCommand { get; set; }
	public int FactorId { get; private set; }

    public CreateModel(IGetProductsService getProductsService, IGetUnitsService getUnitsService, IAddFactorItemService addFactorItemService, IGetFactorService getFactorService, IAddFactorService addFactorService)
    {
        _getProductsService = getProductsService;
        _getUnitsService = getUnitsService;
        _addFactorItemService = addFactorItemService;
        _getFactorService = getFactorService;
        _addFactorService = addFactorService;
    }

    public void OnGet()
	{
	}

	public IActionResult OnPost(AddFactor command)
	{
		if (string.IsNullOrWhiteSpace(command.Description)) command.Description = "ندارد";
		_addFactorService.Add(command);
		return RedirectToPage("/Index");
	}
}
