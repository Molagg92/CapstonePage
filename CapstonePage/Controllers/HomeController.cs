using Microsoft.AspNetCore.Mvc;
using Capstone.Models;
using System.Collections.Generic;

namespace Capstone.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      List<CleaningLady> allCleaningLadys = CleaningLady.GetAll();
      return View(allCleaningLadys);
    }

    [HttpPost("/employees")]
    public ActionResult Employees(string name, int phone)
    {
       CleaningLady starterCleaningLady = new CleaningLady(name ,  phone);
      return View("Index");
    }


    [HttpGet("/employees/new")]
    public ActionResult EmployeeForm()
    {
      return View();
    }
  } 
}