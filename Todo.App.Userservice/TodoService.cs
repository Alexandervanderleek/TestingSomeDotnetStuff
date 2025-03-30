using Todo.App.Core.Interfaces.Repositories;
using Todo.App.Core.Interfaces.Services;
using Todo.App.Core.Models;

namespace Todo.App.TodoService;
public class TodoService (ITodoRepository todoRepository) : ITodoService
{
    public async Task<IEnumerable<TodoItem>> GetAllTodosAsync()
    {
        return await todoRepository.GetAllAsync();
    }
}

