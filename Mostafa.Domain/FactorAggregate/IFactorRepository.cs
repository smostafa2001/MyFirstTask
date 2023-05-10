using System.Linq.Expressions;
using Mostafa.Application.Contracts.FactorAggregate;
using Mostafa.Domain.Entities.Factors;

namespace Mostafa.Domain.FactorAggregate;
public interface IFactorRepository
{
    Factor Get(int id);
    List<Factor> AllFactors { get; }
    void Create(Factor factor);
    bool DoesExists(Expression<Func<Factor, bool>> expression);
    void Save();
    List<FactorItemViewModel> GetItems(long factorId);
}
