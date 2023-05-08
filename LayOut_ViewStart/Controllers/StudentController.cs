using Microsoft.AspNetCore.Mvc;

namespace LayOut_ViewStart.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
