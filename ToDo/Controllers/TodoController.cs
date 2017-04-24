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
            var todo = new Todo() {Name = "Test to do item" , Description="I need to WRITE the To do program"};
            return View(todo);
        }
    }
}