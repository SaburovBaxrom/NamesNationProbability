using NamesNationProbability.Services;

namespace NamesNationProbability.UI;
public class MUI
{
    Service service;
    public MUI(Service ser)
    {
        service = ser;
        Home();
    }

    void Home()
    {
        Console.WriteLine("Enter the name :");
        string name = Console.ReadLine()!;
        SearchNameAndPrint(name);
    }

    void SearchNameAndPrint(string name)
    {
        var response = service.GetCountries(name);
        foreach(var country in response)
        {
            Console.WriteLine(country);
        }
    }


    
}
