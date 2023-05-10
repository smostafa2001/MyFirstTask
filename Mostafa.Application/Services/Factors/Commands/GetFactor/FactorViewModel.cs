using Mostafa.Domain.Entities.Factors;

namespace Mostafa.Application.Services.Factors.Commands.GetFactor;

public class FactorViewModel
{
	public int Id { get; set; }
	public string CreationDate { get; set; }
	public string Description { get; set; }
	public List<FactorItem> FactorItems { get; set; }
	public bool IsRemoved { get; set; }
}