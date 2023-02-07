global using Newtonsoft.Json;
global using RestSharp;
global using System.Collections.ObjectModel;

namespace RestSharpApiAutomationProject2;

public class BaseClass
{
    private readonly string clientURL =  "https://postman-echo.com";
    private readonly string clientURLSW = "https://swapi.dev/api";

    public static ResponseJsonStructure? jsonStructure;

    public static RestClient? restClient;

    public static RestClient? restClientSW;

    public static ReadOnlyCollection<string>? listOfFilms;

    public static ReadOnlyCollection<string>? listOfVehicles;

    public static ReadOnlyCollection<string>? listOfStarships;


    //constructor to initialise the api clients
    public BaseClass()
    {
        restClient = new RestClient(clientURL);
        restClientSW=new RestClient(clientURLSW);
    }
  
}
