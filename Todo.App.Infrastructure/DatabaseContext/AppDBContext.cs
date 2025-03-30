using Microsoft.EntityFrameworkCore;
using Todo.App.Core.Models;


namespace Todo.App.Infrastructure.DatabaseContext;
public class AppDBContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<TodoItem> TodoItems => Set<TodoItem>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<TodoItem>().HasData(
            new TodoItem { Id = 1, Description = "Testing", Name = "Test" },
            new TodoItem { Id = 2, Description = "Testing 2", Name = "Test 2" });
    }

}

