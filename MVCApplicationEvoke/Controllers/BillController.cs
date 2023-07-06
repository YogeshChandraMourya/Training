using Microsoft.AspNetCore.Mvc;
using MVCApplicationForEvoke.Models;

namespace MVCApplicationForEvoke.Controllers
{
    public class BillController : Controller
    {
        public IActionResult Index()
        {
            Bill bill = new Bill();
            bill.BillId = 1;
            bill.BillName = "Spencers";
            bill.BillDescription = "Shopping at Spencers is awesome";
            bill.BillStatus = "Active";
            bill.BillNumber = 143023;
            bill.BillTotal = 4230;

            return View();
        }
    }
}
