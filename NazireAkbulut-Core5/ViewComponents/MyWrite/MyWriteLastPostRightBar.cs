using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.ViewComponents.MyWrite
{
	public class MyWriteLastPostRightBar : ViewComponent
	{
		private readonly IMyWriteService _myWriteService;

		public MyWriteLastPostRightBar(IMyWriteService myWriteService)
		{
			_myWriteService = myWriteService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _myWriteService.MyWriteListTo3LastPost();
			return View(values);
		}
	}
}
