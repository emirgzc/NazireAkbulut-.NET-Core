using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.ViewComponents.SocialMedia
{
	public class SocialMediaListForPublic : ViewComponent
	{
		private readonly ISocialMediaService _socialMediaService;

		public SocialMediaListForPublic(ISocialMediaService socialMediaService)
		{
			_socialMediaService = socialMediaService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _socialMediaService.SocialMediaListForStatus();
			return View(values);
		}
	}
}
