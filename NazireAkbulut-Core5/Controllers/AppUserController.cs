using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NazireAkbulut_Core5.Models.AppUser;
using System.Threading.Tasks;

namespace NazireAkbulut_Core5.Controllers
{
	public class AppUserController : Controller
	{
		private readonly IAppUserService _appUserService;
		private readonly UserManager<AppUser> _userManager;

		public AppUserController(IAppUserService appUserService, UserManager<AppUser> userManager)
		{
			_appUserService = appUserService;
			_userManager = userManager;
		}
		public IActionResult AdUserList()
		{
			var values = _appUserService.TGetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AdUserAdd()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> AdUserAdd(UserRegisterViewModel p)
		{
			AppUser appUser = new AppUser()
			{
				Name = p.Name,
				Surname = p.Surname,
				Email = p.Mail,
				UserName = p.Username
			};
			if (p.Password == p.ConfirmPassword)
			{
				var result = await _userManager.CreateAsync(appUser, p.Password);
				if (result.Succeeded)
				{
					return RedirectToAction("AdUserList");
				}
				else
				{
					foreach (var item in result.Errors)
					{
						ModelState.AddModelError("", item.Description);
					}
				}
			}
			return View(p);
		}
	}
}
