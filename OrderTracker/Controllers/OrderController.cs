using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;

namespace OrderTracker.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/orders")]
    public ActionResult Index()
    {
      return View(Order.GetAll());
    }

    [HttpGet("/orders/new/{vendorId}")]
    public ActionResult CreateForm(int vendorId)
    {
      return View(vendorId);
    }

    [HttpPost("/orders")]
    public ActionResult Create(int vendorId, string description, int price)
    {
      new Order(vendorId, description, price);
      return RedirectToAction(null, "vendors", new { id = vendorId });
    }

    [HttpDelete("/orders/delete_vendor_orders/{vendorId}")]
    public ActionResult Delete_Vendor_Orders(int vendorId)
    {
      Order.DeleteByVendor(vendorId);
      return View();
    }

        [HttpDelete("/orders/delete")]
        public ActionResult DeleteAll()
        {
            Order.ClearAll();
            return View();
        }
    }
}