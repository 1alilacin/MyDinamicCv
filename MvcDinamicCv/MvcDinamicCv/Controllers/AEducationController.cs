using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcDinamicCv.Controllers
{
    public class AEducationController : Controller
    {
        private readonly IEducationService _educationService;

        public AEducationController(IEducationService educationService)
        {
            _educationService = educationService;
        }

        public IActionResult Index()
        {
            var values = _educationService.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddEducation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEducation(EntitiyLayer.Concrete.Education education)
        {
            if (!ModelState.IsValid)
            {
                return View("AddEducation");
            }
            _educationService.TInsert(education);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteEducation(int id)
        {
            var values = _educationService.TGetById(id);
            _educationService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult GetEducation(int id)
        {
            var values = _educationService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult GetEducation(EntitiyLayer.Concrete.Education education)
        {
            var values = _educationService.TGetById(education.ID);
            values.Title = education.Title;
            values.Subtitle1 = education.Subtitle1;
            values.Subtitle2 = education.Subtitle2;
            values.Date = education.Date;
            values.GNO = education.GNO;
            _educationService.TUpdate(values);
            return RedirectToAction("Index");
        }
    }
}
