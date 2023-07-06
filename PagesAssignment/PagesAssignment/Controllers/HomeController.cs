using Microsoft.AspNetCore.Mvc;
using PagesAssignment.Models;
using System.Diagnostics;

namespace PagesAssignment.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Modify()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Git_All()
        {
            return View();
        }
        public IActionResult Git_Commit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Git_Commit(string name)
        {
            ViewBag.Name = string.Format("GitName: {0} has been committed",name);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}