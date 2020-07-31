using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDo.Services.Interfaces;
using ToDoListApp.Models;

namespace ToDoListApp.Controllers
{
    [Route("api/todolist")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoService _todoService;
        // you  need to inject interfaces using microsoft dependency injection and you do that in controller 
        public ToDoController(IToDoService todoService)
        {
            _todoService = todoService;
        }

        // GET api/todolist/items
        // Returns list of all todo items 
        [HttpGet]
        [Route("items")]
        public ActionResult<IEnumerable<ToDoItemModel>> GetAllItems()
        {
            //Todo add things
            var list = _todoService.GetAllItems();
            return Ok(list);
        }


        // GET api/todolist/items
        // Returns list of all Active todo items 
        [HttpGet]
        [Route("items/active")]
        public ActionResult<IEnumerable<ToDoItemModel>> GetAllActiveItems()
        {
            //Todo add all active items 
            var list = _todoService.GetAllActiveItems();
            return Ok(list);
        }

        [HttpPost]
        [Route("items/add")]
        public void Post([FromBody] ToDoItemModel item)
        {
            _todoService.AddItem(item);
        }

    }
}