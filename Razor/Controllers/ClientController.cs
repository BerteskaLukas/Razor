using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace OrderingApplication.Controllers
{
    public class ClientController : Controller
    {
        // GET
        public IActionResult NewClient()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult NewClient(Client newClient)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}