using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoListApp.Models;

namespace ToDo.Services.Interfaces
{
    public interface IToDoRepositories
    {
        List<IEnumerable<ToDoItemModel>> GetTodoItems();
    }
}
