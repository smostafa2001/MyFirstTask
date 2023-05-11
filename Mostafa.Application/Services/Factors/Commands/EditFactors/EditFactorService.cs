using Mostafa.Application.Interfaces.Contexts;

namespace Mostafa.Application.Services.Factors.Commands.EditFactors;

public class EditFactorService : IEditFactorService
{
    private readonly IDbContext _context;

    public EditFactorService(IDbContext context) => _context = context;

    public void Edit(EditFactor command)
    {
        var factor = _context.Factors.FirstOrDefault(f => f.Id == command.Id);
        factor.Edit(command.Description, command.CreationDate);
        _context.SaveChanges();
    }
}
