using System;
using System.Collections.Generic;
using System.Text;
using ToDoListApp.Models;

namespace ToDo.Repositories
{
    public interface IToDoRepository
    {
        //Get all Items in T
        IEnumerable<ToDoItemModel> GetTodoItems();

        IEnumerable<ToDoItemModel> GetAllActiveItems();
    }
}
