using Microsoft.AspNetCore.Routing;
using Todo.App.API.Endpoints;

namespace Todo.App.API;
public static class Bootstrapper
{
    public static IEndpointRouteBuilder UseAPIEndpoints(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .UseTodoEndpoints();
    }
}
