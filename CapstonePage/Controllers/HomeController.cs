using Microsoft.AspNetCore.Mvc;
using Capstone.Models;

namespace Capstone.Controllers
{
    public class HomeController : Controller
    {

      [Route("/")]
    public ActionResult Index()
    {
      
      return View();
    }

    }
}