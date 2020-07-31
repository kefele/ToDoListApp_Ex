using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApp.Models;

namespace ToDo.Repositories
{
    public class ToDoRepository : IToDoRepository
    {
        private readonly IToDoRepository _toDoRepositories;

        IList<ToDoItemModel> itemsCollection;
        public ToDoRepository(IToDoRepository toDoRepository)
        {


            itemsCollection = new List<ToDoItemModel>();
            itemsCollection.Add(new ToDoItemModel { ID = 1, Name = "Add Project", CreateDate = DateTime.Now, Complete = true });
            itemsCollection.Add(new ToDoItemModel { ID = 2, Name = "Add Repo Layer", CreateDate = DateTime.Now, DueDate = DateTime.Now.AddDays(3), Complete = false });
            itemsCollection.Add(new ToDoItemModel { ID = 3, Name = "Add Dependency Injection", CreateDate = DateTime.Now, DueDate = DateTime.Now.AddDays(3), Complete = false });
        }

        public  IEnumerable<ToDoItemModel> GetTodoItems()
        {
            return itemsCollection;
        }

        public IEnumerable<ToDoItemModel> GetAllActiveItems()
        {
            //Todo add all active items 
            var list = itemsCollection.Where(i => !i.Complete);
            return list;
        }
    }
}
