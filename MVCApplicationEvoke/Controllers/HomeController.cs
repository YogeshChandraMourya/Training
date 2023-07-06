using Microsoft.AspNetCore.Mvc;
using MVCApplicationForEvoke.Models;
using System.Diagnostics;

namespace MVCApplicationForEvoke.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.ValueToViews = "This  value is for view";
            ViewBag.SecondValue = "Hi all im from controller";
            ViewBag.number = 100;
            ViewBag.boolean=true;
            return View();
        }

        public string Privacy()
        {
            return "Hi World!!!";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}