using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.ViewComponents.MyWrite
{
	public class MyWriteListHomePageWithCategory4 : ViewComponent
	{
		private readonly IMyWriteService _myWriteService;

		public MyWriteListHomePageWithCategory4(IMyWriteService myWriteService)
		{
			_myWriteService = myWriteService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _myWriteService.MyWriteListHomePageWithCategori(4, 3);
			return View(values);
		}
	}
}
