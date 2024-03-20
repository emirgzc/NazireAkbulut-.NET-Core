using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using NazireAkbulut_Core5.Models.FileNazire;
using Microsoft.AspNetCore.Authorization;

namespace NazireAkbulut_Core5.Controllers
{
    public class FileNazireController : Controller
    {
        private readonly IFileNazireService _fileNazireService;
        private readonly IFileTypeService _fileTypeService;

		public FileNazireController(IFileNazireService fileNazireService, IFileTypeService fileTypeService)
		{
			_fileNazireService = fileNazireService;
			_fileTypeService = fileTypeService;
		}
        [AllowAnonymous]
        public IActionResult Index(int id)
        {
            var values = _fileNazireService.FileNazireToFileType(id);
            return View(values);
        }
        public IActionResult AdFileNazireList()
        {
            var values = _fileNazireService.FileNazireGetAll();
            return View(values);
        }
		[HttpGet]
		public IActionResult AdFileNazireAdd()
		{
			List<SelectListItem> fileTypeValue = (from x in _fileTypeService.TGetList()
												  select new SelectListItem
												  {
													  Text = x.FileTypeTitle,
													  Value = x.FileTypeId.ToString()

												  }).ToList();
			ViewBag.filTyValue = fileTypeValue;
			return View();
		}
		[HttpPost]
		public IActionResult AdFileNazireAdd(FileNazireCreateModel createModel)
		{
			FileNazire f = new FileNazire();
			if (createModel.File != null)
			{
				var extension = Path.GetExtension(createModel.File.FileName);
				var newFileName = Guid.NewGuid() + extension;
				var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files/", newFileName);
				var stream = new FileStream(location, FileMode.Create);
				createModel.File.CopyTo(stream);
				f.File = "/Files/" + newFileName;
			}
			f.FileTypeId = createModel.FileTypeId;
			f.FileDescription = createModel.FileDescription;
			_fileNazireService.TAdd(f);
			return RedirectToAction("AdFileNazireList");
		}
		[HttpGet]
		public IActionResult AdFileNazireUpdate(int id)
		{
			List<SelectListItem> fileTypeValue = (from x in _fileTypeService.TGetList()
												  select new SelectListItem
												  {
													  Text = x.FileTypeTitle,
													  Value = x.FileTypeId.ToString()

												  }).ToList();
			ViewBag.filTyValue = fileTypeValue;
			var values = _fileNazireService.TGetByID(id);
			FileNazireUpdateModel filenazireUpdateModel = new FileNazireUpdateModel();
			filenazireUpdateModel.FileNazireId = values.FileNazireId;
			filenazireUpdateModel.FileTypeId = values.FileTypeId;
			filenazireUpdateModel.FileDescription = values.FileDescription;
			return View(filenazireUpdateModel);
		}
		[HttpPost]
		public IActionResult AdFileNazireUpdate(FileNazireUpdateModel updateModel)
		{
			var values = _fileNazireService.TGetByID(updateModel.FileNazireId);
			if (updateModel.File != null)
			{
				var resource = Directory.GetCurrentDirectory();
				var extension = Path.GetExtension(updateModel.File.FileName);
				var fileName = Guid.NewGuid() + extension;
				var saveLocation = resource + "/wwwroot/Files/" + fileName;
				var stream = new FileStream(saveLocation, FileMode.Create);
				updateModel.File.CopyTo(stream);
				values.File = "/Files/" + fileName;
			}
			values.FileTypeId = updateModel.FileTypeId;
			values.FileDescription = updateModel.FileDescription;
			_fileNazireService.TUpdate(values);

			return RedirectToAction("AdFileNazireList");
		}
		public ActionResult AdFileNazireDoFalse(int id)
		{
			var idser = _fileNazireService.TGetByID(id);
			idser.Status = false;
			_fileNazireService.TUpdate(idser);
			return RedirectToAction("AdFileNazireList");
		}
		public ActionResult AdFileNazireDoTrue(int id)
		{
			var idser = _fileNazireService.TGetByID(id);
			idser.Status = true;
			_fileNazireService.TUpdate(idser);
			return RedirectToAction("AdFileNazireList");
		}
	}
}
