using Microsoft.AspNetCore.Mvc;

namespace aci_aspnetapp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Welcome to aci-aspnetapp!";
            return View();
        }
    }
}
