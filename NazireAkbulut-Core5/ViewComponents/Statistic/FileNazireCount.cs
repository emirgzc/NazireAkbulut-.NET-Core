using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.ViewComponents.Statistic
{
    public class FileNazireCount : ViewComponent
    {
        private readonly IFileNazireService _fileNazireService;

        public FileNazireCount(IFileNazireService fileNazireService)
        {
            _fileNazireService = fileNazireService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _fileNazireService.ListCount();
            ViewBag.count = values;
            return View(values);
        }
    }
}
