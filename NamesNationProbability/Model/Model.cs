using System.Text.Json.Serialization;

namespace NamesNationProbability.Model;
[Serializable]
public class Model : IModel
{
    [JsonPropertyName("country_id")]
    public string Country_id { get; set; }

    [JsonPropertyName("probability")]
    public double Probability  { get; set; }

    public override string ToString()
    {
        return $"country - {Country_id}  probability - {Probability}";
    }
}
