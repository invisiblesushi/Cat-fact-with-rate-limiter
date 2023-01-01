using CatFactConsoleApplication.Services;

namespace CatFactConsoleApplication;

public class Program
{

    private static CatFactApiWrapper _apiWrapper;
    
    public static void Main(string[] args)
    {
        _apiWrapper = new CatFactApiWrapper();



        Console.WriteLine("Cat breeds:");
        var catBreeds = _apiWrapper.FetchCatBreeds().Result;

        catBreeds.data.ForEach(breed =>
        {
            Console.WriteLine($"Breed: {breed.breed}\n" +
                              $"Country: {breed.country}\n" +
                              $"Origin: {breed.origin}\n" +
                              $"Coat: {breed.coat}\n" +
                              $"Pattern: {breed.pattern}\n");
        });
            


        Console.WriteLine("Cat facts:");
        var fact = _apiWrapper.FetchFact(5).Result;
        
        fact.ForEach(catFact =>
        {
            Console.WriteLine($"Fact:\t {catFact.fact}");
        });
    }
}