using System.Net;
using RestSharp;

namespace xunit_poc;

public class UnitTest1
{
    private const string host = "omgvamp-hearthstone-v1.p.rapidapi.com";
    private const string token = "580d2189eamsh4dbf48771535ac9p18eb67jsne7c5336d26d8";

    RestClient client;

    public UnitTest1()
    {
        this.client = new RestClient($"https://{host}");
    }

    private RestRequest CreateRequest(string url, Method method)
    {
        var request = new RestRequest(url, method);

        request.AddHeader("X-RapidAPI-Key", token);
        request.AddHeader("X-RapidAPI-Host", host);

        return request;
    }

    [Fact]
    public void ShouldReturnInfo()
    {
        var request = CreateRequest("/info", Method.Get);
        var response = this.client.Execute<HeartStoneInfo>(request);

        Assert.Equal(response.StatusCode, HttpStatusCode.OK);
        Assert.True(response.Data.Classes.Length > 0);
    }

    [Fact]
    public void ShouldReturnSingleCard()
    {
        var request = CreateRequest("/cards/Ysera", Method.Get);
        var response = this.client.Execute<List<object>>(request);

        Assert.Equal(response.StatusCode, HttpStatusCode.OK);
        Assert.Equal(response.Data.Count(), 9);
    }
}