using Microsoft.AspNetCore.Mvc;
using Capstone.Models;

namespace Capstone.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      CleaningLady starterCleaningLady = new CleaningLady("Lora", 555);
      return View(starterCleaningLady);
    }

    [HttpPost("/employees")]
    public ActionResult Employees(string name, int phone)
    {
       CleaningLady starterCleaningLady = new CleaningLady(name ,  phone);
      return View("Index", starterCleaningLady);
    }


    [HttpGet("/employees/new")]
    public ActionResult EmployeeForm()
    {
      return View();
    }
  } 
}