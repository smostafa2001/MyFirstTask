using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mostafa.Application.Services.Factors.Commands.EditFactors;
using Mostafa.Application.Services.Factors.Commands.GetFactorDetails;

namespace Endpoint.ServiceHost.Pages;

public class EditModel : PageModel
{
    public EditFactor Command { get; set; }

    private readonly IEditFactorService _editFactorService;
    private readonly IGetFactorDetailsService _getFactorDetailsService;

    public EditModel(IEditFactorService editFactorService, IGetFactorDetailsService getFactorDetailsService)
    {
        _editFactorService = editFactorService;
        _getFactorDetailsService = getFactorDetailsService;
    }

    public void OnGet(int id) => Command = _getFactorDetailsService.GetDetails(id);

    public IActionResult OnPost(EditFactor command)
    {
        if (string.IsNullOrWhiteSpace(command.Description)) command.Description = "ندارد";
        if (command.CreationDate == default) command.CreationDate = DateTime.Now;
        _editFactorService.Edit(command);
        return RedirectToPage("/Index");
    }
}
