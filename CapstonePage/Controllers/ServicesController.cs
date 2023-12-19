using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Capstone.Models;

namespace Capstone.Controllers
{
  public class ServicesController : Controller
  {
    private readonly CapstonePageContext _db;
    public ServicesController(CapstonePageContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Service> model = _db.Services.ToList();
      return View(model);
    }

   } 
}























// using System.Collections.Generic;
// using System;
// using Microsoft.AspNetCore.Mvc;
// using Capstone.Models;

// namespace Capstone.Controllers
// {
//   public class ServicesController : Controller
//   {
//     [HttpGet("/services")]
//     public ActionResult Index()
//     {
//       List<Service> allServices = Service.GetAll();
//       return View(allServices);
//     }
//     [HttpGet("/services/new")]
//     public ActionResult New()
//     {
//       return View();
//     }
//     [HttpPost("/services")]
//     public ActionResult Create(string serviceName)
//     {
//       Service newService = new Service(serviceName);
//       return RedirectToAction("Index");
//     }
//       [HttpGet("/services/{id}")]
//     public ActionResult Show(int id)
//     {
//       Dictionary<string, object> model = new Dictionary<string, object>();
//       Service selectedService = Service.Find(id);
//       List<Employee> serviceEmployees = selectedService.Employees;
//       model.Add("service", selectedService);
//       model.Add("employees", serviceEmployees);
//       return View(model);
//     }
//   }
// }