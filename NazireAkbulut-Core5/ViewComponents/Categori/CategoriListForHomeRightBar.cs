using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.ViewComponents.Categori
{
	public class CategoriListForHomeRightBar : ViewComponent
	{
		private readonly ICategoriService _categoriService;

		public CategoriListForHomeRightBar(ICategoriService categoriService)
		{
			_categoriService = categoriService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _categoriService.CategoryListForStatus();
			return View(values);
		}
	}
}
