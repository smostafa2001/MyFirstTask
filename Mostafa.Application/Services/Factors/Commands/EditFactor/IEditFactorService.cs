using Mostafa.Domain.Entities.Factors;

namespace Mostafa.Application.Services.Factors.Commands.EditFactor;
public interface IEditFactorService
{
	public void Edit(int id, string description);
}
