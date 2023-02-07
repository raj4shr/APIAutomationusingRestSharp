
namespace RestSharpApiAutomationProject2;

public class PostmanEchoPage : BaseClass
{
    public RestRequest? restRequest;
    public RestResponse? restResponse;
    public void DateSumRequest()
    {
        restRequest = new();
        //adding query parameters for the end point
        restRequest.AddQueryParameter("timestamp", DateTime.Now);
        restRequest.AddQueryParameter("years", "100");
        string endPoint = "/time/add";
        restRequest.Resource = endPoint;
        restRequest.Method = Method.Get;
        restResponse = restClient.Execute(restRequest);
        //deserialize the response content to custom class
        jsonStructure = JsonConvert.DeserializeObject<ResponseJsonStructure>(restResponse.Content);
        Console.WriteLine(jsonStructure.sum.ToString());
    }

    public void DateSubRequest()
    {
        restRequest = new();
        restRequest.AddQueryParameter("timestamp", jsonStructure.sum.ToString());
        restRequest.AddQueryParameter("years", "100");
        string endPoint = "/time/subtract";
        restRequest.Resource = endPoint;
        restRequest.Method = Method.Get;
        restResponse = restClient.Execute(restRequest);
        //deserialize the response content to custom class
        jsonStructure = JsonConvert.DeserializeObject<ResponseJsonStructure>(restResponse.Content);
        Console.WriteLine(jsonStructure.difference.ToString());
    }

}
