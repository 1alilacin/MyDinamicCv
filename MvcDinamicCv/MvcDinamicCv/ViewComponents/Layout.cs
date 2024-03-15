using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcDinamicCv.ViewComponents
{
    public class About : ViewComponent
    {
        private readonly IAboutService _aboutService;

        public About(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _aboutService.TGetAll();

            return View(values);
        }
    }
    public class Experience : ViewComponent
    {
        private readonly IExperienceService _experienceService;

        public Experience(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _experienceService.TGetAll();
            return View(values);
        }
    }

    public class Education : ViewComponent
    {
        private readonly IEducationService _educationService;

        public Education(IEducationService educationService)
        {
            _educationService = educationService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _educationService.TGetAll();
            return View(values);
        }
    }
    public class Talent : ViewComponent
    {
        private readonly ITalentService _talentService;

        public Talent(ITalentService talentService)
        {
            _talentService = talentService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _talentService.TGetAll();
            return View(values);
        }
    }
    public class Hobby : ViewComponent
    {
        private readonly IHobbyService _hobbyService;

        public Hobby(IHobbyService hobbyService)
        {
            _hobbyService = hobbyService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _hobbyService.TGetAll();
            return View(values);
        }
    }
    public class Certificate : ViewComponent
    {
        private readonly ICertificateService _certificateService;

        public Certificate(ICertificateService certificateService)
        {
            _certificateService = certificateService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _certificateService.TGetAll();

            return View(values);
        }
    }
    public class Contact : ViewComponent
    {
        private readonly IContactService _contactService;

        public Contact(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _contactService.TGetAll();

            return View(values);
        }
    }



}
