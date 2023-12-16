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
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/employees")]
    public ActionResult Create(Employee employee)
    {
      // Assuming you have a static list for simplicity
      List<Employee> allEmployees = Employee.GetAll();
      
      // Add the new employee
      allEmployees.Add(employee);
      
      return RedirectToAction("Index");
    }
  } 
}