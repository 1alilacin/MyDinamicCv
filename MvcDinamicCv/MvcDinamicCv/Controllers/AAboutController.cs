using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcDinamicCv.Controllers
{
    public class AAboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AAboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _aboutService.TGetAll();
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(EntitiyLayer.Concrete.About about)
        {
            var values = _aboutService.TGetById(about.ID);
            values.PhoneNumber = about.PhoneNumber;
            values.Adress = about.Adress;
            values.Surname = about.Surname;
            values.Description = about.Description;
            values.Mail = about.Mail;
            values.Image = about.Image;
            return RedirectToAction("Index");
        }
    }
}
