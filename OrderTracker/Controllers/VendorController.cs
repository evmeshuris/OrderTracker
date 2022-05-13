using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;
using System.Collections.Generic;

namespace OrderTracker.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string description)
    {
      Vendor newVendor = new Vendor(description);
      return RedirectToAction("Index");
    }
    [HttpPost("/vendors/delete")]
    public ActionResult DeleteAll()
    {
      Vendor.ClearAll();
      return View();
    }
  }
}