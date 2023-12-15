using Microsoft.AspNetCore.Mvc;

namespace Capstone.Controllers
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