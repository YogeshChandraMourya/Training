using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UnitTestMVC_20_06_23_HW.Models;
using UserService;

namespace UnitTestMVC_20_06_23_HW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserMessageService _userMessageService;

        public HomeController(IUserMessageService userMessageService,ILogger<HomeController> logger)
        {
            _logger = logger;
            _userMessageService = userMessageService;
        }

        public IActionResult Index()
        {
            ViewBag.Message1 = _userMessageService.GetElevationFromDB("2");
            ViewBag.Display=_userMessageService.GetMessageFromDB();
            //ViewBag.Message2 = _userMessageService.LocalGetMessageTestData();
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