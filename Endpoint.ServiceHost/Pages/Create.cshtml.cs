using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mostafa.Application.Services.Factors.Commands.AddFactors;

namespace Endpoint.ServiceHost.Pages;

public class CreateModel : PageModel
{
    private readonly IAddFactorService _addFactorService;
    public AddFactor Command { get; set; }
    public CreateModel(IAddFactorService addFactorService) => _addFactorService = addFactorService;

    public void OnGet()
    {
    }

    public IActionResult OnPost(AddFactor command)
    {
        if (string.IsNullOrWhiteSpace(command.Description)) command.Description = "ندارد";
        if (command.CreationDate == default) command.CreationDate = DateTime.Now;
        int id = _addFactorService.Add(command);
        return RedirectToPage("/Items", new {Id = id});
    }
}
