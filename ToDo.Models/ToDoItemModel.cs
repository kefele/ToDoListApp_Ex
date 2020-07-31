using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListApp.Models
{
    public class ToDoItemModel
    {
        public int ID { get; set; }
        public string Name { get; set;}

        public DateTime CreateDate { get; set; }

        public DateTime? DueDate { get; set; }

        public bool Complete { get; set;}

    }
}
