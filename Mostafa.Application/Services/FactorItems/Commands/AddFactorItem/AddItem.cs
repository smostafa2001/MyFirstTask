namespace Mostafa.Application.Services.FactorItems.Commands.AddFactorItem;

public class AddItem
{
    public int ProductId { get; set; }
    public int UnitId { get; set; }
    public int Quantity { get; set; }
    public int Tax { get; set; }
    public int UnitPrice { get; set; }
    public int Discount { get; set; }
    public int FactorId { get; set; }
}
