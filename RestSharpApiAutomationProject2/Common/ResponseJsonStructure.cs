
namespace RestSharpApiAutomationProject2;

//class to deserialize the reponse data for postmanecho object
public class ResponseJsonStructure
{
    public string? sum { get; set; }

    public string? difference { get; set; } 

}

//class to deserialize the response data for star wars api people object
public class StarWarsReturnInfo
{
    public ReadOnlyCollection<string> films { get; set; }
}

//class to deserialize the response data for star wars api films object
public class StarWarsFilmsInfo
{
    public string? title { get; set; }
    public string? opening_crawl { get; set; }  
    public string? director { get; set; }
}


//class to deserialize the response data for star wars api starship object
public class StarWarsStarshipsInfo
{
    public ReadOnlyCollection<StarWarsStarShipsResults>? results { get; set; }
}

public class StarWarsStarShipsResults
{
    public string? name { get; set; }
    public string? model { get; set; }
    public string? manufacturer { get; set; }
    public string? starship_class { get; set; }
}