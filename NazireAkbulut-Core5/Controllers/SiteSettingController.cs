using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.Controllers
{
	public class SiteSettingController : Controller
	{
		private readonly ISiteSettingService _siteSettingService;

		public SiteSettingController(ISiteSettingService siteSettingService)
		{
			_siteSettingService = siteSettingService;
		}
		[HttpGet]
		public IActionResult AdSiteSettingUpdate(int id)
		{
			var values = _siteSettingService.TGetByID(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult AdSiteSettingUpdate(SiteSetting siteSetting)
		{
			_siteSettingService.TUpdate(siteSetting);
			return RedirectToAction("AdSiteSettingUpdate", "SiteSetting", new { id = siteSetting.SiteSettingId });
		}		
	}
}
