using System.Collections.Generic;
using ToDo.Repositories;
using ToDo.Services.Interfaces;
using ToDoListApp.Models;

namespace ToDo.Services
{
    public class ToDoService : IToDoService
    {
        private readonly IToDoRepository _toDoRepository;

        IList<ToDoItemModel> itemsCollection;

        public ToDoService(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;

        }


        public IEnumerable<ToDoItemModel> GetAllItems()
        {
            // todo: call repository layer to return list of items 

            return _toDoRepository.GetTodoItems();
        }

        public IEnumerable<ToDoItemModel> GetAllActiveItems()
        {
            // todo: call repository layer to return list of items 
            //var list = itemsCollection.Where(i => !i.Complete);
            return _toDoRepository.GetAllActiveItems();
        }

        public void AddItem(ToDoItemModel item)
        {
            _toDoRepository.AddItem(item);
        }
    }
}
