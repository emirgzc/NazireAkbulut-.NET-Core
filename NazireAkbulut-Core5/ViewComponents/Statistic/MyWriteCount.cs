using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.ViewComponents.Statistic
{
    public class MyWriteCount : ViewComponent
    {
        private readonly IMyWriteService _myWriteService;

        public MyWriteCount(IMyWriteService myWriteService)
        {
            _myWriteService = myWriteService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _myWriteService.ListCount();
            ViewBag.count = values;
            return View(values);
        }
    }
}
