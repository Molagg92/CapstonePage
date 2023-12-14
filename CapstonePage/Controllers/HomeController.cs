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
      return View(starterCleaningLady);

    
      
    }
  }
}