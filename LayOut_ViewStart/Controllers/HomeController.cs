using Microsoft.AspNetCore.Mvc;

namespace LayOut_ViewStart.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Show()
        {
            return View();
        }
    }
}
