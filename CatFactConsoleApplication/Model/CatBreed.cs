namespace CatFactConsoleApplication.Model;

public class CatBreed
{
    public int current_page { get; set; }
    public List<BreedData> data { get; set; }
    public string first_page_url { get; set; }
    public int from { get; set; }
    public int last_page { get; set; }
    public string last_page_url { get; set; }
    public string next_page_url { get; set; }
    public string path { get; set; }
    public int per_page { get; set; }
    public object prev_page_url { get; set; }
    public int to { get; set; }
    public int total { get; set; }
}

public class BreedData
{
    public string breed { get; set; }
    public string country { get; set; }
    public string origin { get; set; }
    public string coat { get; set; }
    public string pattern { get; set; }
}


