using Mostafa.Application.Interfaces.Contexts;

namespace Mostafa.Application.Services.Factors.Commands.EditFactor;

public class EditFactorService : IEditFactorService
{
    private readonly IDbContext _context;

    public EditFactorService(IDbContext context) => _context = context;

    public void Edit(int id, string description)
    {
        var factor = _context.Factors.FirstOrDefault(f => f.Id == id);
        factor.EditDescription(description);
        _context.SaveChanges();
    }
}
