namespace Mostafa.Domain.Entities.Factors;

public class Factor
{
    public int Id { get; private set; }
    public DateTime CreationDate { get; private set; }
    public string Description { get; private set; }
    public List<FactorItem> FactorItems { get; private set; }
    public bool IsRemoved { get; private set; }

    public Factor(string description, DateTime creationDate)
    {
        Description = description;
        CreationDate = creationDate;
        FactorItems = new();
        IsRemoved = false;
    }

    public void Remove() => IsRemoved = true;
    public void Edit(string newDescription, DateTime newCreationDate)
    {
        Description = newDescription;
        CreationDate = newCreationDate;
    }
}
