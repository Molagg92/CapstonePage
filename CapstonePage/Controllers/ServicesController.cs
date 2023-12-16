using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Capstone.Models;

namespace Capstone.Controllers
{
  public class ServicesController : Controller
  {
    [HttpGet("/services")]
    public ActionResult Index()
    {
      List<Service> allServices = Service.GetAll();
      return View(allServices);
    }
  }
}