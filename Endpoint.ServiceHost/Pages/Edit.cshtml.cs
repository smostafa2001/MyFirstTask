using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mostafa.Application.Services.Factors.Commands.EditFactor;
using Mostafa.Application.Services.Factors.Commands.GetFactor;

namespace Endpoint.ServiceHost.Pages;

public class EditModel : PageModel
{
	public int Id { get; private set; }
	public string Description { get; private set; }
	private readonly IGetFactorService _getFactorService;
	private readonly IEditFactorService _editFactorService;

	public EditModel(IEditFactorService editFactorService, IGetFactorService getFactorService)
	{
		_editFactorService = editFactorService;
		_getFactorService = getFactorService;
	}

	public void OnGet(int id)
	{
		Id = id;
		Description = _getFactorService.Get(id).Description;
	}

	public IActionResult OnPost(int id, string description)
	{
		Description = description;
		Id = id;
		if (string.IsNullOrWhiteSpace(Description))
		{
			Description = "ندارد";
		}

		_editFactorService.Edit(Id, Description);
		return RedirectToPage("/Index");
	}
}
