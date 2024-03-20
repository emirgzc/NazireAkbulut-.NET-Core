using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.Controllers
{
	public class CategoryController : Controller
	{
		private readonly ICategoriService _categoriService;

		public CategoryController(ICategoriService categoriService)
		{
			_categoriService = categoriService;
		}
		public IActionResult AdCategoriList()
		{
			var values = _categoriService.TGetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AdCategoryAdd()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AdCategoryAdd(Categori categori)
		{
			_categoriService.TAdd(categori);
			return RedirectToAction("AdCategoriList");
		}
		[HttpGet]
		public IActionResult AdCategoryUpdate(int id)
		{
			var values = _categoriService.TGetByID(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult AdCategoryUpdate(Categori categori)
		{
			_categoriService.TUpdate(categori);
			return RedirectToAction("AdCategoriList");
		}
		public ActionResult AdCategoryDoFalse(int id)
		{
			var idser = _categoriService.TGetByID(id);
			idser.CategoriStatus = false;
			_categoriService.TUpdate(idser);
			return RedirectToAction("AdCategoriList");
		}
		public ActionResult AdCategoryDoTrue(int id)
		{
			var idser = _categoriService.TGetByID(id);
			idser.CategoriStatus = true;
			_categoriService.TUpdate(idser);
			return RedirectToAction("AdCategoriList");
		}
	}
}
