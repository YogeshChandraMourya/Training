using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Trial.Models;

namespace Trial.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()

        {   IList<Class> list = new List<Class>();
            list.Add(new Class() { Id = 5, Name="Thor"});
            list.Add(new Class() { Id = 6,Name="Tony"});
            list.Add(new Class() { Id = 7, Name="Steve"});

            ViewData["list"] = list;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}