using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.App.Core.Models;

namespace Todo.App.Core.Interfaces.Repositories;
public interface ITodoRepository
{
    Task<IEnumerable<TodoItem>> GetAllAsync();
}

