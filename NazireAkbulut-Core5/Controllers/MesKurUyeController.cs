using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.Controllers
{
	public class MesKurUyeController : Controller
	{
		private readonly IMesKurUyeService _mesKurUyeService;

		public MesKurUyeController(IMesKurUyeService mesKurUyeService)
		{
			_mesKurUyeService = mesKurUyeService;
		}
        [AllowAnonymous]
        public IActionResult Index()
		{
			var values = _mesKurUyeService.MesKurUyeListForStatus();
			return View(values);
		}
		public IActionResult AdMesKurUyeList()
		{
			var values = _mesKurUyeService.TGetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AdMesKurUyeAdd()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AdMesKurUyeAdd(MesKurUye mesKurUye)
		{
			_mesKurUyeService.TAdd(mesKurUye);
			return RedirectToAction("AdMesKurUyeList");
		}
		[HttpGet]
		public IActionResult AdMesKurUyeUpdate(int id)
		{
			var values = _mesKurUyeService.TGetByID(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult AdMesKurUyeUpdate(MesKurUye mesKurUye)
		{
			_mesKurUyeService.TUpdate(mesKurUye);
			return RedirectToAction("AdMesKurUyeList");
		}
		public ActionResult AdMesKurUyeDoFalse(int id)
		{
			var idser = _mesKurUyeService.TGetByID(id);
			idser.Status = false;
			_mesKurUyeService.TUpdate(idser);
			return RedirectToAction("AdMesKurUyeList");
		}
		public ActionResult AdMesKurUyeDoTrue(int id)
		{
			var idser = _mesKurUyeService.TGetByID(id);
			idser.Status = true;
			_mesKurUyeService.TUpdate(idser);
			return RedirectToAction("AdMesKurUyeList");
		}
	}
}
