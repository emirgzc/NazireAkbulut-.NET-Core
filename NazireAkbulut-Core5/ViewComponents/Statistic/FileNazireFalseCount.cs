using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.ViewComponents.Statistic
{
    public class FileNazireFalseCount : ViewComponent
    {
        private readonly IFileNazireService _fileNazireService;

        public FileNazireFalseCount(IFileNazireService fileNazireService)
        {
            _fileNazireService = fileNazireService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _fileNazireService.FileNazireFalseCount();
            ViewBag.count = values;
            return View(values);
        }
    }
}
