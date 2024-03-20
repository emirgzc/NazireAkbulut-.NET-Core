using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.ViewComponents.FileType
{
	public class FileTypeListRightBar : ViewComponent
	{
		private readonly IFileTypeService _fileTypeService;

		public FileTypeListRightBar(IFileTypeService categoriService)
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
