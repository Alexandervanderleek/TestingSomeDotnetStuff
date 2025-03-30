using Todo.App.Core.Interfaces.Services;
using Todo.App.TodoService;

namespace Todo.App.APIHost.Configuration;
public static class ServiceConfiguration
{
    public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ITodoService, Service>();

        return services;
    }
}

