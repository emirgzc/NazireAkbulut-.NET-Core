using BusinessLayer.Abstract;
using DNTCaptcha.Core;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using X.PagedList;

namespace NazireAkbulut_Core5.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly ISiteSettingService _siteSettingService;
        private readonly IDNTCaptchaValidatorService _validatorService;
        private readonly DNTCaptchaOptions _captchaOptions;

        public ContactController(IContactService contactService, ISiteSettingService siteSettingService, IDNTCaptchaValidatorService validatorService, IOptions<DNTCaptchaOptions> captchaOptions)
        {
            _contactService = contactService;
            _siteSettingService = siteSettingService;
            _validatorService = validatorService;
            _captchaOptions = captchaOptions == null ? throw new ArgumentNullException(nameof(captchaOptions)) : captchaOptions.Value;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            var values = _siteSettingService.TGetList();
            return View(values);
        }
        [AllowAnonymous]
        [HttpGet]
        public PartialViewResult AddContact()
        {
            return PartialView();
        }
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddContact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                if (!_validatorService.HasRequestValidCaptchaEntry(Language.English, DisplayMode.ShowDigits))
                {
                    this.ModelState.AddModelError(_captchaOptions.CaptchaComponent.CaptchaInputName, "Lütfen doğrulama kodunu giriniz.");
                    TempData["AlertMessage"] = "Üzgünüz, yorumunuz gönderilirken bir hata oluştu. Lütfen daha sonra tekrar deneyin.";          
                    return RedirectToAction("Index");
                }
            }
            TempData["alertType"] = true;
            TempData["AlertMessage"] = "Mesajınız başarılı bir şekilde alınmıştır.";
            contact.ContactDate = DateTime.Now;
            _contactService.TAdd(contact);
            return RedirectToAction("Index");
        }
		public IActionResult AdContactList(int page = 1)
		{
			var values = _contactService.ContactListByDate().ToPagedList(page, 10);
			return View(values);
		}
        public IActionResult AdContactDetail(int id)
		{
			var values = _contactService.ContactDetail(id);
			return View(values);
		}
		public ActionResult AdContactDelete(int id)
		{
			var contact = _contactService.TGetByID(id);
			_contactService.TDelete(contact);
			return RedirectToAction("AdContactList");
		}
	}
}
