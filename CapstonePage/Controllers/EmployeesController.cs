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
    public ActionResult Create(Employee employee)
    {
      List<Employee> allEmployees = Employee.GetAll();
      allEmployees.Add(employee);
      
      return RedirectToAction("Index");
    }

    [HttpPost("/employees/delete")]
    public ActionResult DeleteAll()
    {
      Employee.ClearAll();
      return View();
    }
    

  } 
}