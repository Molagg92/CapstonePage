using Microsoft.AspNetCore.Mvc;
using Capstone.Models;

namespace Capstone.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      Employee starterCleaningLady = new Employee("Add first CleaningLady to To Do List");
      return View(starterCleaningLady);
    }
  }
}