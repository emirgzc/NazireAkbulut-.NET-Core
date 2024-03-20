using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.ViewComponents.MyWrite
{
	public class MyWriteListHomePageWithCategory5 : ViewComponent
	{
		private readonly IMyWriteService _myWriteService;

		public MyWriteListHomePageWithCategory5(IMyWriteService myWriteService)
		{
			_myWriteService = myWriteService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _myWriteService.MyWriteListHomePageWithCategori(8, 3);
			return View(values);
		}
	}
}
