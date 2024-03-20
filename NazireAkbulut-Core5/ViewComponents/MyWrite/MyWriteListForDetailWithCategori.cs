using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.ViewComponents.MyWrite
{
	public class MyWriteListForDetailWithCategori : ViewComponent
	{
		private readonly IMyWriteService _myWriteService;

		public MyWriteListForDetailWithCategori(IMyWriteService myWriteService)
		{
			_myWriteService = myWriteService;
		}

		public IViewComponentResult Invoke(int id)
		{
			var values = _myWriteService.MyWriteListForDetailWithCategori(id);
			return View(values);
		}
	}
}
