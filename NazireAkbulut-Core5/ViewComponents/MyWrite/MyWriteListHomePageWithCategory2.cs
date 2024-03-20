using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.ViewComponents.MyWrite
{
	public class MyWriteListHomePageWithCategory2 : ViewComponent
	{
		private readonly IMyWriteService _myWriteService;

		public MyWriteListHomePageWithCategory2(IMyWriteService myWriteService)
		{
			_myWriteService = myWriteService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _myWriteService.MyWriteListHomePageWithCategori(2, 3);
			return View(values);
		}
	}
}
