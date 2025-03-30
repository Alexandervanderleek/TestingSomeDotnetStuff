using Todo.App.API;

namespace Todo.App.APIHost.Configuration;
public static class ApplicationConfiguration
{
    public static IApplicationBuilder ConfigureApp(this IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.UseAPIEndpoints();
        });

        return app;
    }
}

