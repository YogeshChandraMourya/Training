using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewDataViewBag.Models;

namespace ViewDataViewBag.Controllers
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
            Avengers avengers = new Avengers()
            {
                Id = 1,
                Name = "Captain America",
                Description = "First Avenger",

            };

            ViewData["data"] = avengers;
            ViewData["Header"] = "Avengers Assemble";

            ViewBag.Dialogue = "I can do this all day";


            return View();
        }

        public IActionResult Privacy()
        {
            xmen data=new xmen() { 
            Id = 1,
            Name="Wolverine",
            Description="FastHealer",
            };

            return View(data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}