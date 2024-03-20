using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NazireAkbulut_Core5.Models.About;
using System;
using System.IO;

namespace NazireAkbulut_Core5.Controllers
{
	public class AboutController : Controller
	{
		private readonly IAboutService _aboutService;

		public AboutController(IAboutService aboutService)
		{
			_aboutService = aboutService;
		}
        [AllowAnonymous]
        public IActionResult Index()
		{
			var values = _aboutService.TGetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AdAboutUpdate(int id)
		{
			var values = _aboutService.TGetByID(id);
			AboutUpdateModel aboutUpdateModel = new AboutUpdateModel();
			aboutUpdateModel.AboutId = values.AboutId;
			aboutUpdateModel.AboutTitle = values.AboutTitle;
			aboutUpdateModel.AboutDescription = values.AboutDescription;
			return View(aboutUpdateModel);
		}
		[HttpPost]
		public IActionResult AdAboutUpdate(AboutUpdateModel updateModel)
		{
			var values = _aboutService.TGetByID(updateModel.AboutId);
			if (updateModel.AboutImage != null)
			{
				var resource = Directory.GetCurrentDirectory();
				var extension = Path.GetExtension(updateModel.AboutImage.FileName);
				var imageName = Guid.NewGuid() + extension;
				var saveLocation = resource + "/wwwroot/Images/" + imageName;
				var stream = new FileStream(saveLocation, FileMode.Create);
				updateModel.AboutImage.CopyTo(stream);
				values.AboutImage = "/Images/" + imageName;
			}
			values.AboutTitle = updateModel.AboutTitle;
			values.AboutDescription = updateModel.AboutDescription;
			_aboutService.TUpdate(values);

			return RedirectToAction("AdAboutUpdate", "About", new { id = updateModel.AboutId });
		}
	}
}
