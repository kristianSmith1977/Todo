using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDo.Models;


namespace ToDo.Controllers
{
    public class TodoController : Controller
    {
        // GET: Todo
        public ActionResult Index()
        {
            var todos = new List<Todo>
            {
                new Todo{Name= "test1", Description="This is the info for test1"},
                new Todo{Name= "Test2", Description="This is the info for test2"}
            };

           
            
            return View(todos);
        }
    }
}