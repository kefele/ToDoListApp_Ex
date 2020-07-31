using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

            itemsCollection = new List<ToDoItemModel>();            
            itemsCollection.Add(new ToDoItemModel { ID = 1, Name = "Add Project", CreateDate = DateTime.Now, Complete = true });
            itemsCollection.Add(new ToDoItemModel { ID = 2, Name = "Add Repo Layer", CreateDate = DateTime.Now, DueDate = DateTime.Now.AddDays(3), Complete = false });
            itemsCollection.Add(new ToDoItemModel { ID = 3, Name = "Add Dependency Injection", CreateDate = DateTime.Now, DueDate = DateTime.Now.AddDays(3), Complete = false });
        }

        public  IEnumerable<ToDoItemModel> GetAllItems()
        {
            // todo: call repository layer to return list of items 
            
            return  _toDoRepository.GetTodoItems();
        }

        public IEnumerable<ToDoItemModel> GetAllActiveItems()
        {
            // todo: call repository layer to return list of items 
            var list = itemsCollection.Where(i => !i.Complete);
            return _toDoRepository.GetAllActiveItems();
        }
    }
}
