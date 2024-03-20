using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.ViewComponents.SocialMedia
{
	public class SocialMediaWithAboutInHome : ViewComponent
	{
		private readonly IWriterService _writerService;

		public SocialMediaWithAboutInHome(IWriterService writerService)
		{
			_writerService = writerService;
		}

		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
