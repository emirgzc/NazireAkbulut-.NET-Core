using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace NazireAkbulut_Core5.ViewComponents.MyWrite
{
	public class MyWriteHomePageLastBig : ViewComponent
	{
		private readonly IMyWriteService _myWriteService;

		public MyWriteHomePageLastBig(IMyWriteService myWriteService)
		{
			_myWriteService = myWriteService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _myWriteService.MyWriteListToHomePageLast();
			return View(values);
		}
	}
}
