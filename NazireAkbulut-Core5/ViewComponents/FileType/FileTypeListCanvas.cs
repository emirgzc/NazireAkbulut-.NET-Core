using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.ViewComponents.FileType
{
	public class FileTypeListCanvas : ViewComponent
	{
		private readonly IFileTypeService _fileTypeService;

		public FileTypeListCanvas(IFileTypeService categoriService)
		{
			_fileTypeService = categoriService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _fileTypeService.FileTypeListForStatus();
			return View(values);
		}
	}
}
