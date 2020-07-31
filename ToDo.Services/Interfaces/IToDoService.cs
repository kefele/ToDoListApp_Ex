using System.Collections.Generic;
using ToDoListApp.Models;

namespace ToDo.Services.Interfaces
{
    public interface IToDoService
    {
        IEnumerable<ToDoItemModel> GetAllItems();

        IEnumerable<ToDoItemModel> GetAllActiveItems();

        void AddItem(ToDoItemModel item);

    }
}
