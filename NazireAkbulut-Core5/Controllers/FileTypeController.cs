using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.Controllers
{
    public class FileTypeController : Controller
    {
        private readonly IFileTypeService _fileTypeService;

        public FileTypeController(IFileTypeService fileTypeService)
        {
            _fileTypeService = fileTypeService;
        }
        public IActionResult AdFileTypeList()
        {
            var values = _fileTypeService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AdFileTypeAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdFileTypeAdd(FileType FileType)
        {
            _fileTypeService.TAdd(FileType);
            return RedirectToAction("AdFileTypeList");
        }
        [HttpGet]
        public IActionResult AdFileTypeUpdate(int id)
        {
            var values = _fileTypeService.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult AdFileTypeUpdate(FileType FileType)
        {
            _fileTypeService.TUpdate(FileType);
            return RedirectToAction("AdFileTypeList");
        }
        public ActionResult AdFileTypeDoFalse(int id)
        {
            var idser = _fileTypeService.TGetByID(id);
            idser.Status = false;
            _fileTypeService.TUpdate(idser);
            return RedirectToAction("AdFileTypeList");
        }
        public ActionResult AdFileTypeDoTrue(int id)
        {
            var idser = _fileTypeService.TGetByID(id);
            idser.Status = true;
            _fileTypeService.TUpdate(idser);
            return RedirectToAction("AdFileTypeList");
        }
    }
}
