using System.Collections.Generic;
using ToDoListApp.Models;

namespace ToDo.Repositories
{
    public interface IToDoRepository
    {
        //Get all Items in T
        IEnumerable<ToDoItemModel> GetTodoItems();

        IEnumerable<ToDoItemModel> GetAllActiveItems();

        void AddItem(ToDoItemModel item);
    }
}
