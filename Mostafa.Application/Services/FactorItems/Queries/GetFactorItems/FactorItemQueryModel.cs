namespace Mostafa.Application.Services.FactorItems.Queries.GetFactorItems;

public class FactorItemQueryModel
{
    public int Id { get; set; }
    public string Product { get; set; }
    public string Unit { get; set; }
    public int Quantity { get; set; }
    public int Tax { get; set; }
    public int UnitPrice { get; set; }
    public int Discount { get; set; }
    public int TotalPrice => (UnitPrice * Quantity) + Tax - Discount;
    public int FactorId { get; set; }
}
