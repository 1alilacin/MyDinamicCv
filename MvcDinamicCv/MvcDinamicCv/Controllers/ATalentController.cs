using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcDinamicCv.Controllers
{
    public class ATalentController : Controller
    {
        private readonly ITalentService _talentService;

        public ATalentController(ITalentService talentService)
        {
            _talentService = talentService;
        }

        public IActionResult Index()
        {
            var values=_talentService.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddTalent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTalent(EntitiyLayer.Concrete.Talent talent)
        {
            _talentService.TInsert(talent);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteTalent(int id)
        {
            var values=_talentService.TGetById(id);
            _talentService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditTalent(int id)
        {
            var values = _talentService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditTalent(EntitiyLayer.Concrete.Talent talent)
        {
            var values = _talentService.TGetById(talent.ID);
            values.Talents = talent.Talents;
            _talentService.TUpdate(values);
            return RedirectToAction("Index");
        }
    }
}
