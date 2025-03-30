using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Todo.App.Core.Interfaces.Services;
using Todo.App.Core.Models;

namespace Todo.App.API.Endpoints;
internal static class TodoEndpoints
{
    internal static IEndpointRouteBuilder UseTodoEndpoints(this IEndpointRouteBuilder endpoints)
    {
        var todoGroup = endpoints.MapGroup("/api/todo").WithTags("Todo");

        todoGroup.MapGet("/", async ([FromServices] ITodoService todoService) =>
        {
            var todos = await todoService.GetAllTodosAsync();
            return Results.Ok(todos);
        })
            .WithName("GetAllTodos").Produces(StatusCodes.Status200OK, typeof(IEnumerable<TodoItem>));
        

        return endpoints;
    }
}
