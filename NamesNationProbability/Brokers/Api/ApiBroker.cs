using NamesNationProbability.Model;
using System.Text.Json;

namespace NamesNationProbability.Brokers.Api;

public partial class ApiBroker : IApiBroker
{
    private const string baseUrl = @"https://api.nationalize.io?";

    public ICountry GetCountries(string name)
    {
        string url = baseUrl + "name=" + name;
        HttpClient client = new HttpClient();

        var response = client.GetAsync(url).Result; 
        var data = response.Content.ReadAsStringAsync().Result;
        var countryList = JsonSerializer.Deserialize<Country>(data);
        return countryList;
    }
}
