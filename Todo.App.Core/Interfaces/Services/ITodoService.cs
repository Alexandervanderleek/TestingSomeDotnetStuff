using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.App.Core.Interfaces.Services;
internal interface ITodoService
{
    Task CreateTodoAsync();
}

