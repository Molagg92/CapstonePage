using Microsoft.AspNetCore.Mvc;
using Capstone.Models;
using System.Collections.Generic;

namespace Capstone.Controllers
{
  public class EmployeesController : Controller
  {
    [HttpGet("/employees")]
    public ActionResult Index()
    {
      List<Employee> allEmployees = Employee.GetAll();
      return View(allEmployees);
    }

    [HttpGet("/employees/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/employees")]
    public ActionResult Create(string name, int phone)
    {
      Employee myEmployee = new Employee(name, phone);
      return RedirectToAction("Index");
    }

    [HttpPost("/employees/delete")]
    public ActionResult DeleteAll()
    {
      Employee.ClearAll();
      return View();
    }
    [HttpGet("/employees/{id}")]
    public ActionResult Show(int id)
    {
      Employee foundEmployee = Employee.Find(id);
      return View(foundEmployee);
    }

  } 
}