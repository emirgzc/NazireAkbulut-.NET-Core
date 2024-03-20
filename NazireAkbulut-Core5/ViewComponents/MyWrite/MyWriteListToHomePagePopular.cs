using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace NazireAkbulut_Core5.ViewComponents.MyWrite
{
	public class MyWriteListToHomePagePopular : ViewComponent
	{
		private readonly IMyWriteService _myWriteService;

		public MyWriteListToHomePagePopular(IMyWriteService myWriteService)
		{
			_myWriteService = myWriteService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _myWriteService.MyWriteListPopular();
			return View(values);
		}
	}
}
