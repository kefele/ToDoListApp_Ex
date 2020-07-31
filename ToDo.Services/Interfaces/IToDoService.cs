using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoListApp.Models;

namespace ToDo.Services.Interfaces
{
    public interface IToDoService
    {
        IEnumerable<ToDoItemModel> GetAllItems();
        

        IEnumerable<ToDoItemModel> GetAllActiveItems();

    }
}
