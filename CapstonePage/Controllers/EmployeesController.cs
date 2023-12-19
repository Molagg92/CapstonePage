using Microsoft.AspNetCore.Mvc;
using Capstone.Models;
using System.Collections.Generic;

namespace Capstone.Controllers
{
  // public class EmployeesController : Controller
  // {
  //   [HttpGet("/employees")]
  //   public ActionResult Index()
  //   {
  //     List<Employee> allEmployees = Employee.GetAll();
  //     return View(allEmployees);
  //   }

  //   [HttpGet("/services/{serviceId}/employees/new")]
  //   public ActionResult New(int serviceId)
  //   {
  //     Service service = Service.Find(serviceId);
  //    return View(service);
  //   }

  //   [HttpPost("/employees")]
  //   public ActionResult Create(string name, int phone)
  //   {
  //     Employee myEmployee = new Employee(name, phone);
  //     return RedirectToAction("Index");
  //   }

  //   [HttpPost("/employees/delete")]
  //   public ActionResult DeleteAll()
  //   {
  //     Employee.ClearAll();
  //     return View();
  //   }
  //   [HttpGet("/employees/{id}")]
  //   public ActionResult Show(int id)
  //   {
  //     Employee foundEmployee = Employee.Find(id);
  //     return View(foundEmployee);
  //   }
  //   [HttpGet("/services/{serviceId}/employees/{employeeId}")]
  //   public ActionResult Show(int serviceId, int employeeId)
  //   {
  //     Employee employee = Employee.Find(employeeId);
  //     Service service = Service.Find(serviceId);
  //     Dictionary<string, object> model = new Dictionary<string, object>();
  //     model.Add("employee", employee);
  //     model.Add("service", service);
  //     return View(model);
  //   }

  // } 
}