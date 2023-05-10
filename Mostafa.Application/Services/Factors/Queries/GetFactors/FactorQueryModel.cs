using Mostafa.Domain.Entities.Factors;

namespace Mostafa.Application.Services.Factors.Queries.GetFactors;

public class FactorQueryModel
{
    public int Id { get; set; }
    public DateTime CreationDate { get; set; }
    public string Description { get; set; }
    public List<FactorItem> FactorItems { get; set; }
    public bool IsRemoved { get; set; }
}
