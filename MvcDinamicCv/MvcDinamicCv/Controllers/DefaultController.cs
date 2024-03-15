using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcDinamicCv.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IAboutService _aboutService;
        private readonly IExperienceService _experienceService;

        public DefaultController(IAboutService aboutService, IExperienceService experienceService)
        {
            _experienceService = experienceService;
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            var values = _aboutService.TGetAll();
            return View(values);
        }
        
    }
}
