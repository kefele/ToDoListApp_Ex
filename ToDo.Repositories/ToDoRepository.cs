using System;
using System.Collections.Generic;
using System.Linq;
using ToDoListApp.Models;

namespace ToDo.Repositories
{
    public class ToDoRepository : IToDoRepository
    {
        IList<ToDoItemModel> itemsCollection;
        public ToDoRepository()
        {


            itemsCollection = new List<ToDoItemModel>();
            itemsCollection.Add(new ToDoItemModel { ID = 1, Name = "Add Project", CreateDate = DateTime.Now, Complete = true });
            itemsCollection.Add(new ToDoItemModel { ID = 2, Name = "Add Repo Layer", CreateDate = DateTime.Now, DueDate = DateTime.Now.AddDays(3), Complete = false });
            itemsCollection.Add(new ToDoItemModel { ID = 3, Name = "Add Dependency Injection", CreateDate = DateTime.Now, DueDate = DateTime.Now.AddDays(3), Complete = false });
        }

        public IEnumerable<ToDoItemModel> GetTodoItems()
        {
            return itemsCollection;
        }

        public IEnumerable<ToDoItemModel> GetAllActiveItems()
        {
            //Todo add all active items 
            var list = itemsCollection.Where(i => !i.Complete);
            return list;
        }

        public void AddItem(ToDoItemModel item)
        {
            itemsCollection.Add(item);
        }

        //public IEnumerable<ToDoItemModel> GetTodoItem(int ID)
        //{
        //    var item = itemsCollection.Where(i => i.ID == ID).FirstOrDefault();

        //    return  itemsCollection.Where(i => i.ID == ID).FirstOrDefault();
        //    return item;
        //}
    }
}
