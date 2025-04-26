
using Api.Extensions;
namespace Api.Endpoints;

public class HelloEndpoints : IEndpoint
{
    private const string tag = "Hello";

    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("hello/get", () => Results.Ok("Hello World"))
             .WithTags(tag);
    }
}