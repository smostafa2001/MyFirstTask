namespace Mostafa.Domain.Entities.Factors;

public class Factor
{
    public int Id { get; private set; }
    public DateTime CreationDate { get; private set; }
    public string Description { get; private set; }
    public List<FactorItem> FactorItems { get; private set; }
    public bool IsRemoved { get; private set; }

    public Factor(string description)
    {
        Description = description;
        FactorItems = new List<FactorItem>();
        CreationDate = DateTime.Now;
        IsRemoved = false;
    }

    public void Remove() => IsRemoved = true;
    public void Restore() => IsRemoved = false;
    public void EditDescription(string newDescription) => Description = newDescription;
    public void Add(FactorItem item) => FactorItems.Add(item);

}
