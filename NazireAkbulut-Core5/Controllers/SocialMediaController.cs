using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.Controllers
{
	public class SocialMediaController : Controller
	{
		private readonly ISocialMediaService _socialMediaService;

		public SocialMediaController(ISocialMediaService socialMediaService)
		{
			_socialMediaService = socialMediaService;
		}
		public IActionResult AdSocialMediaList(int id)
		{
			var values = _socialMediaService.TGetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AdSocialMediaAdd()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AdSocialMediaAdd(SocialMedia socialMedia)
		{
			_socialMediaService.TAdd(socialMedia);
			return RedirectToAction("AdSocialMediaList");
		}
		[HttpGet]
		public IActionResult AdSocialMediaUpdate(int id)
		{
			var values = _socialMediaService.TGetByID(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult AdSocialMediaUpdate(SocialMedia socialMedia)
		{
			_socialMediaService.TUpdate(socialMedia);
			return RedirectToAction("AdSocialMediaList");
		}
		public ActionResult AdSocialMediaDoFalse(int id)
		{
			var idser = _socialMediaService.TGetByID(id);
			idser.Status = false;
			_socialMediaService.TUpdate(idser);
			return RedirectToAction("AdSocialMediaList");
		}
		public ActionResult AdSocialMediaDoTrue(int id)
		{
			var idser = _socialMediaService.TGetByID(id);
			idser.Status = true;
			_socialMediaService.TUpdate(idser);
			return RedirectToAction("AdSocialMediaList");
		}
	}
}
