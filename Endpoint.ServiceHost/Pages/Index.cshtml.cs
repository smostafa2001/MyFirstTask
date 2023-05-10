using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mostafa.Application.Services.Factors.Commands.GetFactor;
using Mostafa.Application.Services.Factors.Commands.RemoveFactor;
using Mostafa.Application.Services.Factors.Queries.GetFactors;

namespace Endpoint.ServiceHost.Pages;
public class IndexModel : PageModel
{
    public List<FactorQueryModel> Factors { get; private set; }
    private readonly ILogger<IndexModel> _logger;
    private readonly IGetFactorsService _getFactorsService;
    private readonly IRemoveFactorService _removeFactorService;
    private readonly IGetFactorService _getFactorService;


    public IndexModel(ILogger<IndexModel> logger, IGetFactorsService getFactorsService, IGetFactorService getFactorService, IRemoveFactorService removeFactorService)
    {
        _logger = logger;
        _getFactorsService = getFactorsService;
		_getFactorService = getFactorService;
		_removeFactorService = removeFactorService;
	}

    public void OnGet() => Factors = _getFactorsService.GetFactors();
    public IActionResult OnGetRemove(int id)
    {
        _removeFactorService.Remove(id);
        return RedirectToPage("/Index");
    }
}
