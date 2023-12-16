using Microsoft.AspNetCore.Mvc;
using Capstone.Models;

namespace Capstone.Controllers
{
    public class HomeController : Controller
    {

      [Route("/")]
    public ActionResult Index()
    {
      Employee starterEmployee = new Employee("Add first item toList", 555);
      return View(starterEmployee);
    }

    }
}