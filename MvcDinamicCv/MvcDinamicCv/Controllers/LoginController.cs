using Microsoft.AspNetCore.Mvc;

namespace MvcDinamicCv.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
