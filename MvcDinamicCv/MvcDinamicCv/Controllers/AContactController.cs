using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcDinamicCv.Controllers
{
    public class AContactController : Controller
    {
        private readonly IContactService _contactService;

        public AContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.TGetAll();
            return View(values);
        }
    }
}
