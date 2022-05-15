using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;

namespace OrderTracker.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
            //new Vendor("bingo bongo");
            return View();
            //return RedirectToAction("/vendors");

        }

    }
}