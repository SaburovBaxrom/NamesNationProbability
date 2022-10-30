using NamesNationProbability.Brokers.Api;
using NamesNationProbability.Model;
using System.Linq;

namespace NamesNationProbability.Services;

public class Service : IService
{
    private readonly IApiBroker apiBroker;

    public Service()
    {
        apiBroker = new ApiBroker();
    }

    public List<IModel> GetCountries(string name)
    {
        var model = apiBroker.GetCountries(name);

        return model.Countries.ToList<IModel>();
    }

    
}
