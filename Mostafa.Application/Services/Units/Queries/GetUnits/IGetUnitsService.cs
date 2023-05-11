using Mostafa.Domain.Entities.Units;

namespace Mostafa.Application.Services.Units.Queries.GetUnits;
public interface IGetUnitsService
{
    List<Unit> Units { get; }
}