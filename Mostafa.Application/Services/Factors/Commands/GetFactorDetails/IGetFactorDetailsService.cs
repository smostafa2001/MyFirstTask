using Mostafa.Application.Services.Factors.Commands.EditFactors;

namespace Mostafa.Application.Services.Factors.Commands.GetFactorDetails;
public interface IGetFactorDetailsService
{
    EditFactor GetDetails(int id);
}