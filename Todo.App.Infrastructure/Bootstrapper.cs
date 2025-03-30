using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Todo.App.Core.Interfaces.Repositories;
using Todo.App.Infrastructure.DatabaseContext;
using Todo.App.Infrastructure.Repositories;

namespace Todo.App.Infrastructure;
public static class Bootstrapper
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {

        services.AddDbContext<AppDBContext>(options =>
        {
            options.UseInMemoryDatabase("TodoDB");
        });

        services.AddScoped<ITodoRepository, TodoRepository>();

        return services;
    }
}

