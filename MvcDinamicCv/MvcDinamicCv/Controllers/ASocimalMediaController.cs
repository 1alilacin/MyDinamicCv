using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcDinamicCv.Controllers
{
    public class ASocimalMediaController : Controller
    {
        private readonly ISocialMediaService _socialMediaService;

        public ASocimalMediaController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IActionResult Index()
        {
            var values = _socialMediaService.TGetAll();
            return View(values);
        }
    }
}
