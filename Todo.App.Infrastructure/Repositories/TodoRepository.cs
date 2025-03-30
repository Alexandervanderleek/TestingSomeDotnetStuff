using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.App.Core.Interfaces.Repositories;
using Todo.App.Core.Models;
using Todo.App.Infrastructure.DatabaseContext;

namespace Todo.App.Infrastructure.Repositories;
public class TodoRepository (AppDBContext dbContext) : ITodoRepository
{
    public async Task<IEnumerable<TodoItem>> GetAllAsync()
    {
        return await dbContext.TodoItems.ToListAsync();
    }
}

