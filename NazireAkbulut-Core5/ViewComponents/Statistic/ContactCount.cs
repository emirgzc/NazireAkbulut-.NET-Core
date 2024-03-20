using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.ViewComponents.Statistic
{
    public class ContactCount : ViewComponent
    {
        private readonly IContactService _contactService;

        public ContactCount(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _contactService.ListCount();
            ViewBag.count = values;
            return View();
        }
    }
}
