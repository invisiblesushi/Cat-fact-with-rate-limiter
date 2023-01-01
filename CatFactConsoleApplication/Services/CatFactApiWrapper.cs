using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Polly;
using Polly.RateLimit;
using CatFactConsoleApplication.Model;

namespace CatFactConsoleApplication.Services;

public class CatFactApiWrapper
{
    private static HttpClient? _httpClient;
    private readonly Uri _apiUrlBase;
    private static AsyncRateLimitPolicy? _rateLimit;

    public CatFactApiWrapper()
    {
        _apiUrlBase = new Uri("https://catfact.ninja/");
        _httpClient = new HttpClient();
        
        // 2 executions every 10 secounds
        _rateLimit = Policy.RateLimitAsync(2, TimeSpan.FromSeconds(10));
    }
    
    public async Task<CatBreed> FetchCatBreeds()
    {
        var catBreed = new CatBreed()
        {
            data = new List<BreedData>()
        };
        
        var url = $@"{_apiUrlBase}breeds";

        // Fetch results from api
        // Sets url and loops as long as next_page_url is not null
        while (url != null)
        {
            var result = await FetchResult<CatBreed>(url);
            url = result.next_page_url;
            catBreed.data.AddRange(result.data);
        }
        
        return catBreed;
    }
    
    public async Task<List<CatFact>> FetchFact(int numberOfFacts)
    {
        var url = $@"{_apiUrlBase}fact";

        List<CatFact> catFacts = new List<CatFact>();

        for (int i = 0; i < numberOfFacts; i++)
        {
            catFacts.AddRange(new[] {await FetchResult<CatFact>(url)});
        }

        return catFacts;
    }
    
    private async Task<TResult> FetchResult<TResult>(string url)
    {
        var response = await GetRequestAsync(url);
        var json = JsonConvert.DeserializeObject<JToken>(response) ?? new object().ToString();
        var result = JsonConvert.DeserializeObject<TResult>(json.ToString());
        
        return result;
    }

    private static async Task<string> GetRequestAsync(string url)
    {
        bool tryAgain = true;
        HttpResponseMessage response = null;
        
        while (tryAgain)
        {
            try
            {
                response = await _rateLimit.ExecuteAsync(() => _httpClient!.GetAsync(url));
            }
            catch (RateLimitRejectedException ex)
            {
                response = null;
                string retryAfter = DateTimeOffset.UtcNow
                    .Add(ex.RetryAfter)
                    .ToUnixTimeSeconds()
                    .ToString(CultureInfo.InvariantCulture);
                Console.WriteLine($"Rate limited {ex.RetryAfter}");
                Thread.Sleep(ex.RetryAfter);
            }

            if (response == null)
            {
                tryAgain = true;
            }
            else
            {
                tryAgain = false;
            }

        }

        return response.Content.ReadAsStringAsync().Result;
    }


    

    /*
    var response = await rateLimit.ExecuteAsync(() => _httpClient!.GetAsync(url));
    Console.WriteLine(DateTime.Now);


    //var response = await _httpClient!.GetAsync(url);

    if (!response.IsSuccessStatusCode)
    {
        throw new ApplicationException($"Api endpoint {url} failed with status {response.StatusCode}");
    }

    return response.Content.ReadAsStringAsync().Result;
}
*/

}