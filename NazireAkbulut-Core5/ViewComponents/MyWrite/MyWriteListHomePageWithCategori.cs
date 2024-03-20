using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace NazireAkbulut_Core5.ViewComponents.MyWrite
{
	public class MyWriteListHomePageWithCategori : ViewComponent
	{
		private readonly IMyWriteService _myWriteService;
		private readonly ICategoriService _categoriService;

		public MyWriteListHomePageWithCategori(IMyWriteService myWriteService, ICategoriService categoriService)
		{
			_myWriteService = myWriteService;
			_categoriService = categoriService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _myWriteService.MyWriteListHomePageWithCategori(1, 5);
			return View(values);
		}
	}
}
