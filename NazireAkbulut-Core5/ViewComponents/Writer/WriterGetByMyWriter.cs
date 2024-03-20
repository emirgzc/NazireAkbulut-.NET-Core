using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.ViewComponents.Writer
{
	public class WriterGetByMyWriter : ViewComponent
	{
		private readonly IWriterService _writerService;

		public WriterGetByMyWriter(IWriterService writerService)
		{
			_writerService = writerService;
		}

		public IViewComponentResult Invoke(int id)
		{
			var values = _writerService.WriteGetWithMyWriter(id);
			return View(values);
		}
	}
}
