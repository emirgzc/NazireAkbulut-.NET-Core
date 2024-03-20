using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.Controllers
{
    public class YukLisDokUyeController : Controller
    {
        private readonly IYukLisDokJuriService _yukLisDokJuriService;

        public YukLisDokUyeController(IYukLisDokJuriService yukLisDokJuriService)
        {
            _yukLisDokJuriService = yukLisDokJuriService;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            var values = _yukLisDokJuriService.YukLisDokJuriListForStatus();
            return View(values);
        }
		public IActionResult AdYukLisDokJuriList()
		{
			var values = _yukLisDokJuriService.TGetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AdYukLisDokJuriAdd()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AdYukLisDokJuriAdd(YukLisDokJuri YukLisDokJuri)
		{
			_yukLisDokJuriService.TAdd(YukLisDokJuri);
			return RedirectToAction("AdYukLisDokJuriList");
		}
		[HttpGet]
		public IActionResult AdYukLisDokJuriUpdate(int id)
		{
			var values = _yukLisDokJuriService.TGetByID(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult AdYukLisDokJuriUpdate(YukLisDokJuri YukLisDokJuri)
		{
			_yukLisDokJuriService.TUpdate(YukLisDokJuri);
			return RedirectToAction("AdYukLisDokJuriList");
		}
		public ActionResult AdYukLisDokJuriDoFalse(int id)
		{
			var idser = _yukLisDokJuriService.TGetByID(id);
			idser.Status = false;
			_yukLisDokJuriService.TUpdate(idser);
			return RedirectToAction("AdYukLisDokJuriList");
		}
		public ActionResult AdYukLisDokJuriDoTrue(int id)
		{
			var idser = _yukLisDokJuriService.TGetByID(id);
			idser.Status = true;
			_yukLisDokJuriService.TUpdate(idser);
			return RedirectToAction("AdYukLisDokJuriList");
		}
	}
}
