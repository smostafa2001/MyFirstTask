using Mostafa.Domain.Entities.Products;
using Mostafa.Domain.Entities.Units;

namespace Mostafa.Domain.Entities.Factors;
public class FactorItem
{
    public int Id { get; private set; }
    public int ProductId { get; private set; }
    public Product Product { get; private set; }
    public int UnitId { get; private set; }
    public Unit Unit { get; private set; }
    public int Quantity { get; private set; }
    public int Tax { get; private set; }
    public int UnitPrice { get; private set; }
    public int Discount { get; private set; }
    public int TotalPrice => (UnitPrice * Quantity) + Tax - Discount;
    public int FactorId { get; private set; }

    public FactorItem(int productId, int unitId, int quantity, int tax, int unitPrice, int discount, int factorId)
    {
        ProductId = productId;
        UnitId = unitId;
        Quantity = quantity;
        Tax = tax;
        UnitPrice = unitPrice;
        Discount = discount;
        FactorId = factorId;
    }

    public void Edit(int productId, int unitId, int quantity, int tax, int unitPrice, int discount, int factorId)
    {
        ProductId = productId;
        UnitId = unitId;
        Quantity = quantity;
        Tax = tax;
        UnitPrice = unitPrice;
        Discount = discount;
        FactorId = factorId;
    }
}
