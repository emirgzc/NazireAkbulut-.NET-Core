using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.ViewComponents.MyWrite
{
	public class MyWriteListHomePageWithCategory3 : ViewComponent
	{
		private readonly IMyWriteService _myWriteService;

		public MyWriteListHomePageWithCategory3(IMyWriteService myWriteService)
		{
			_myWriteService = myWriteService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _myWriteService.MyWriteListHomePageWithCategori(3, 2);
			return View(values);
		}
	}
}
