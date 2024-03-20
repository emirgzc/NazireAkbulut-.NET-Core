using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.Controllers
{	
	public class DefaultController : Controller
	{
        [AllowAnonymous]
        public IActionResult Index()
		{
			return View();
		}
        [AllowAnonymous]
        public PartialViewResult TopHeroPartial()
		{
			return PartialView();
		}
		public IActionResult AdIndex()
		{
			return View();
		}
	}
}
