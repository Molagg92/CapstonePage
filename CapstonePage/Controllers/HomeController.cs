using Microsoft.AspNetCore.Mvc;
// using Capstone.Models;

namespace Capstone.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Employee()
    {
      // Employee starterCleaningLady = new Employee("Add first Cleaning Lady to the List");
      // return View(starterCleaningLady);
      return View();
    }
  }
}