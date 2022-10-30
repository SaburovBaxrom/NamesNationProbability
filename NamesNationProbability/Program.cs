using NamesNationProbability.Services;
using NamesNationProbability.UI;
namespace NamesNationProbability;

public class Program
{
    static void Main(string[] args)
    {
        Service service = new Service();
        new MUI(service);
    }
}