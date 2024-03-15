using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcDinamicCv.Controllers
{
    public class AHobbyController : Controller
    {
        private readonly IHobbyService _hobbyService;

        public AHobbyController(IHobbyService hobbyService)
        {
            _hobbyService = hobbyService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _hobbyService.TGetAll();
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(EntitiyLayer.Concrete.Hobby hobby)
        {
            var values = _hobbyService.TGetById(hobby.ID);
            values.Description1 = hobby.Description1;
            values.Description2 = hobby.Description2;
            return RedirectToAction("Index");
        }
    }
}
