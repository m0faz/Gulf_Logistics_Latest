using Gulf_Logistics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gulf_Logistics.Controllers
{
    public class AuthenticationController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            return RedirectToAction("Order", "Logistic");
        }
    }
}
