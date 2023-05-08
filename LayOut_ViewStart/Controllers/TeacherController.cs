using Microsoft.AspNetCore.Mvc;

namespace LayOut_ViewStart.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
