using Microsoft.AspNetCore.Mvc;
using Capstone.Models;

namespace Capstone.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
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
  }
}