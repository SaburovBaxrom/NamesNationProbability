using System.Text.Json.Serialization;

namespace NamesNationProbability.Model;


public interface ICountry
{
    public List<Model> Countries { get; set;}
    
    public string Name { get; set; }
}
