using Microsoft.AspNetCore.Mvc;
using Capstone.Models;

namespace Capstone.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      CleaningLady starterCleaningLady = new CleaningLady();
      return View(starterCleaningLady);
    }

    [Route("/employee")]
    public ActionResult Employee()
    {
      CleaningLady starterCleaningLady = new CleaningLady();
      starterCleaningLady.Name = "Lora";
      starterCleaningLady.Phone = 555;
      return View(starterCleaningLady);
    }

    [Route("/form")]
    public ActionResult EmployeeForm()
    {
      return View(); 
    }

    [Route("/newEmployee")]
    public ActionResult newEmployee(int phone, string name)
    {
      CleaningLady myLetterVariable = new CleaningLady();
      myLetterVariable.Name = name;
      myLetterVariable.Phone = phone;
      return View(myLetterVariable);
    }
  } 
}