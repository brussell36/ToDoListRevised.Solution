using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}