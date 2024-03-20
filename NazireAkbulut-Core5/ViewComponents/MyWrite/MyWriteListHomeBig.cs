using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace NazireAkbulut_Core5.ViewComponents.MyWrite
{
	public class MyWriteListHomeBig : ViewComponent
	{
		private readonly IMyWriteService _myWriteService;

		public MyWriteListHomeBig(IMyWriteService myWriteService)
		{
			_myWriteService = myWriteService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _myWriteService.MyWriteToHomePageLastList();
			return View(values);
		}
	}
}
