using System.Net;
using Refresh.HttpServer.Endpoints;

namespace RefreshTests.HttpServer.Endpoints;

public class MultipleEndpointsTest : EndpointGroup
{
    [Endpoint("/a")]
    [Endpoint("/b")]
    public string Test(HttpListenerContext context)
    {
        return "works";
    }
}