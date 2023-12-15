using Microsoft.AspNetCore.Mvc;
using Capstone.Models;

namespace Capstone.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      CleaningLady starterCleaningLady = new CleaningLady("Lora", 555);
      return View(starterCleaningLady);
    }

    [Route("/employees")]
    public ActionResult Employees(string description)
    {
       CleaningLady starterCleaningLady = new CleaningLady(description ,  555);
      return View("Index", starterCleaningLady);
    }


    [Route("/employees/new")]
    public ActionResult newEmployee()
    {
      return View();
    }
  } 
}