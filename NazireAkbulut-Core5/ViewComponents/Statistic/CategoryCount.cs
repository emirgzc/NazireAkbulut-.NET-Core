using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.ViewComponents.Statistic
{
    public class CategoryCount : ViewComponent
    {
        private readonly ICategoriService _categoriService;

        public CategoryCount(ICategoriService categoriService)
        {
            _categoriService = categoriService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _categoriService.ListCount();
            ViewBag.count = values;
            return View();
        }
    }
}
