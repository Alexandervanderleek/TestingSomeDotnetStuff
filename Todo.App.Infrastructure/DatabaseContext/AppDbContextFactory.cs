using Microsoft.EntityFrameworkCore.Design;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Todo.App.Infrastructure.DatabaseContext
{
    internal class AppDbContextFactory : IDesignTimeDbContextFactory<AppDBContext>
    {
        public AppDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Todo.App.APIHost"))
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.development.json", optional: true)
                .Build();

            var builder = new DbContextOptionsBuilder<AppDBContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseSqlServer(connectionString);

            return new AppDBContext(builder.Options);
        }
    }
}
