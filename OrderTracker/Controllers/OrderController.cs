using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;
using System.Collections.Generic;

namespace OrderTracker.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/orders")]
    public ActionResult Index()
    {

      List<Order> allOrders = Order.GetAll();
      return View(allOrders);
    }

    [HttpGet("/orders/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/orders")]
    public ActionResult Create(string description, int price)
    {
      Order newOrder = new Order(description, price);
      return RedirectToAction("Index");
    }
    [HttpPost("/orders/delete")]
    public ActionResult DeleteAll()
    {
      Order.ClearAll();
      return View();
    }
  }
}