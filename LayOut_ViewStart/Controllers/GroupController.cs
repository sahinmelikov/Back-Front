using Microsoft.AspNetCore.Mvc;

namespace LayOut_ViewStart.Controllers
{
    public class GroupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
