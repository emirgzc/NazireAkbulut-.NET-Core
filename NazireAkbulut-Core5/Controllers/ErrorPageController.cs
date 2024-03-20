using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.Controllers
{
	[AllowAnonymous]
	public class ErrorPageController : Controller
	{
		public IActionResult Error404(int code)
		{
			return View();
		}
	}
}
