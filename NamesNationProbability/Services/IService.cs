
using NamesNationProbability.Brokers.Api;
using NamesNationProbability.Model;
namespace NamesNationProbability.Services;

public interface IService
{
    public List<IModel> GetCountries(string name);
    
}
