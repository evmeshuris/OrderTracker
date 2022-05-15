using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;

namespace OrderTracker.Controllers
{
    public class VendorsController : Controller
    {

        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            return View(Vendor.GetAll());
        }

        [HttpGet("/vendors/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/vendors")]
        public ActionResult Create(string description)
        {
            new Vendor(description);
            return RedirectToAction("Index");
        }

        [HttpPost("/vendors/delete")]
        public ActionResult DeleteAll()
        {
            Vendor.ClearAll();
            return View();
        }

        [HttpGet("/vendors/{id}")]
        public ActionResult Show(int id)
        {
            return View(Vendor.GetAll().Find(v => v.Id == id));
        }

        [HttpGet("/vendors/deleteorders/{id}")]
        public ActionResult DeleteVendorOrders(int id)
        {
            Order.DeleteByVendor(id);
            return RedirectToAction("Show", new { id = id });

        }

        [HttpGet("/vendors/deleteorder/{vendorId}/{orderId}")]
        public ActionResult DeleteOrder(int vendorId, int orderId)
        {
            Order.Delete(orderId);
            return RedirectToAction("Show", new { id = vendorId });
        }
    }
}
