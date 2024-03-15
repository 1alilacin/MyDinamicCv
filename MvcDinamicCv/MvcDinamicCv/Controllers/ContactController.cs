using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MvcDinamicCv.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly Context _context;

        public ContactController(IContactService contactService, Context context)
        {
            _context = context;
            _contactService = contactService;
        }
        

        [HttpGet]
        public PartialViewResult Contact()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contact.Date=DateTime.Parse(DateTime.Now.ToShortDateString());
            _contactService.TInsert(contact);
            return RedirectToAction("Index","Default");
        }
    }
}
