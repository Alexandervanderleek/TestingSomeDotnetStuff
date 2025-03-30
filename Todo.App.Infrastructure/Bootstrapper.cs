using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Todo.App.Core.Interfaces.Repositories;
using Todo.App.Infrastructure.DatabaseContext;
using Todo.App.Infrastructure.Repositories;

namespace Todo.App.Infrastructure;
public static class Bootstrapper
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddDbContext<AppDBContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });

        services.AddScoped<ITodoRepository, TodoRepository>();

        return services;
    }
}

