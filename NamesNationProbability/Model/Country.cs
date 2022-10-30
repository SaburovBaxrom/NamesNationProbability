
using System.Text.Json.Serialization;

namespace NamesNationProbability.Model;
[Serializable]
public class Country : ICountry
{
    [JsonPropertyName("country")]
    public List<Model> Countries { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
