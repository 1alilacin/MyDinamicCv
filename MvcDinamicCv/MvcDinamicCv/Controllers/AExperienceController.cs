using BusinessLayer.Abstract;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using MvcDinamicCv.ViewComponents;

namespace MvcDinamicCv.Controllers
{
    public class AExperienceController : Controller
    {
        private readonly IExperienceService _experienceService;

        public AExperienceController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        public IActionResult Index()
        {
            var values = _experienceService.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(EntitiyLayer.Concrete.Experience experience)
        {
            _experienceService.TInsert(experience);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var values = _experienceService.TGetById(id);
            _experienceService.TDelete(values);
            return RedirectToAction("Index");
        }
        public IActionResult GetExperience(int id)
        {
            var values = _experienceService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult GetExperience(EntitiyLayer.Concrete.Experience experience)
        {
            var values = _experienceService.TGetById(experience.ID);
            values.Title = experience.Title;
            values.Description = experience.Description;
            values.Date= experience.Date;
            _experienceService.TUpdate(values);
            return RedirectToAction("Index","AExperience");
        }
    }
}
