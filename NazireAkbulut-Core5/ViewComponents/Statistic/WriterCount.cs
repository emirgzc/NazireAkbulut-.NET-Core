using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.ViewComponents.Statistic
{
    public class WriterCount : ViewComponent
    {
        private readonly IWriterService _writerService;

        public WriterCount(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _writerService.ListCount();
            ViewBag.count = values;
            return View(values);
        }
    }
}
