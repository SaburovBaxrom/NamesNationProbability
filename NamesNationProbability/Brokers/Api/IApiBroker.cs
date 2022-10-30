using NamesNationProbability.Model;
namespace NamesNationProbability.Brokers.Api;

public interface IApiBroker
{
    public ICountry GetCountries(string name);
    
}
