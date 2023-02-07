

namespace RestSharpApiAutomationProject2;

public class StarWarsPage : BaseClass
{
    public RestRequest? restRequest;
    public RestResponse? restResponse;
    StarWarsReturnInfo _StarWarsReturnInfo;
    StarWarsFilmsInfo _StarWarsFilmsInfo;
    StarWarsStarshipsInfo _StarWarsStarshipsInfo;

    public StarWarsPage()
    {
        _StarWarsReturnInfo = new StarWarsReturnInfo();
        _StarWarsFilmsInfo = new StarWarsFilmsInfo();
        _StarWarsStarshipsInfo= new StarWarsStarshipsInfo();    
        restRequest = new RestRequest();
    }

    public void GetFilmsByActor()
    {
        restRequest.Resource = "/people/1";
        restRequest.Method = Method.Get;
        restResponse=restClientSW.Execute(restRequest);
        //deserialize the response content to custom class
        _StarWarsReturnInfo = JsonConvert.DeserializeObject<StarWarsReturnInfo>(restResponse.Content);
        listOfFilms = _StarWarsReturnInfo.films;
        Console.WriteLine(_StarWarsReturnInfo.films.Count);
    }

    public void ListFilmsByActor()
    {
        //displaying all the films for a particular character--request data is passed on from response data of GetFilmsByActor()
        for(int i=0;i<listOfFilms.Count;i++)
        {
            restRequest.Resource = listOfFilms[i].ToString();
            restRequest.Method= Method.Get;
            restResponse = restClientSW.Execute(restRequest);
            //deserialize the response content to custom class
            _StarWarsFilmsInfo = JsonConvert.DeserializeObject<StarWarsFilmsInfo>(restResponse.Content);
            Console.WriteLine(_StarWarsFilmsInfo.title);
            Console.WriteLine("\n\n");
            Console.WriteLine(_StarWarsFilmsInfo.opening_crawl);
            Console.WriteLine("\n\n");
            Console.WriteLine(_StarWarsFilmsInfo.director);
            Console.WriteLine("\n\n\n\n");
        }
        
    }

    public void GetAllStarWarsStarships()
    {
        restRequest.Resource = "/starships";
        restRequest.Method= Method.Get;
        restResponse = restClientSW.Execute(restRequest);
        //deserialize the response content to custom class
        _StarWarsStarshipsInfo = JsonConvert.DeserializeObject<StarWarsStarshipsInfo>(restResponse.Content);
        //displaying all the starships 
        for(int i=0;i<_StarWarsStarshipsInfo.results.Count;i++)
        {
            Console.WriteLine(_StarWarsStarshipsInfo.results[i].name);
            Console.WriteLine(_StarWarsStarshipsInfo.results[i].starship_class);
            Console.WriteLine(_StarWarsStarshipsInfo.results[i].manufacturer);
            Console.WriteLine(_StarWarsStarshipsInfo.results[i].model);
            Console.WriteLine("\n\n\n\n");
        }
    }
}
