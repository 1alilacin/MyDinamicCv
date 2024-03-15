using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcDinamicCv.Controllers
{
    public class ACertificateController : Controller
    {
        private readonly ICertificateService _certificateService;

        public ACertificateController(ICertificateService certificateService)
        {
            _certificateService = certificateService;
        }

        public IActionResult Index()
        {
            var values = _certificateService.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult UpdateCertificate(int id)
        {
            var values = _certificateService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateCertificate(EntitiyLayer.Concrete.Certificate certificate)
        {
            var values = _certificateService.TGetById(certificate.ID);
            values.Description = certificate.Description;
            _certificateService.TUpdate(values);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCertificate(int id)
        {
            var values = _certificateService.TGetById(id);
            _certificateService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddCertificate()
        {
            return View();
            //var values= _certificateService.TGetById(id);
            //return View(values);
        }
        [HttpPost]
        public IActionResult AddCertificate(EntitiyLayer.Concrete.Certificate certificate)
        {
            _certificateService.TInsert(certificate);
            return RedirectToAction("Index");
        }
    }
}
