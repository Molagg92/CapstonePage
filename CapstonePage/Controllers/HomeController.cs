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
      List<Employee> allEmployees = Employee.GetAll();
      return View(allEmployees);
    }

    [HttpPost("/employees")]
    public ActionResult Employees(string name, int phone)
    {
       Employee starterEmployee = new Employee(name ,  phone);
      return View("Index");
    }


    [HttpGet("/employees/new")]
    public ActionResult EmployeeForm()
    {
      return View();
    }
  } 
}