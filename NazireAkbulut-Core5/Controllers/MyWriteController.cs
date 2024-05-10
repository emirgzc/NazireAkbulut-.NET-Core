using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NazireAkbulut_Core5.Models.About;
using NazireAkbulut_Core5.Models.MyWrite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using X.PagedList;

namespace NazireAkbulut_Core5.Controllers
{
	public class MyWriteController : Controller
	{
		private readonly IMyWriteService _myWriteService;
		private readonly ICategoriService _categoriService;
		private readonly IWriterService _writerService;

		public MyWriteController(IMyWriteService myWriteService, ICategoriService categoriService, IWriterService writerService)
		{
			_myWriteService = myWriteService;
			_categoriService = categoriService;
			_writerService = writerService;
		}
        [AllowAnonymous]
        public IActionResult Index(int id, int page = 1)
		{
			var values = _myWriteService.MyWriteListWithCategory(id).ToPagedList(page, 10);
			string categoryName = _myWriteService.MyWriteCategoryName(id);
			ViewBag.categoryName = categoryName;
			return View(values);
		}
        [AllowAnonymous]
        public IActionResult GetAllMyWrite(int page = 1)
		{
			var values = _myWriteService.MyWriteListGetAllWithStatus().ToPagedList(page, 10);
			return View(values);
		}
        [AllowAnonymous]
        public IActionResult MyWriteDetail(int id)
		{
			ViewBag.myWriteId = id;
			var values = _myWriteService.MyWriteDetails(id);
			return View(values);
		}
		public IActionResult AdMyWriteList(int page = 1)
		{
			var values = _myWriteService.MyWriteListGetAll().ToPagedList(page, 12);
			return View(values);
		}
		[HttpGet]
		public IActionResult AdMyWriteAdd()
		{
			List<SelectListItem> categoryValue = (from x in _categoriService.TGetList()
												  select new SelectListItem
												  {
													  Text = x.CategoriTitle,
													  Value = x.CategoriId.ToString()

												  }).ToList();
			ViewBag.catValue = categoryValue;

			List<SelectListItem> writerValue = (from x in _writerService.TGetList()
												select new SelectListItem
												{
													Text = x.Name + " " + x.Surname,
													Value = x.WriterId.ToString()

												}).ToList();
			ViewBag.writValue = writerValue;
			return View();
		}
		[HttpPost]
		public IActionResult AdMyWriteAdd(MyWriteCreateModel createModel)
		{
			MyWrite w = new MyWrite();
			if (createModel.Image != null)
			{
				var extension = Path.GetExtension(createModel.Image.FileName);
				var newImageName = Guid.NewGuid() + extension;
				var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/", newImageName);
				var stream = new FileStream(location, FileMode.Create);
				createModel.Image.CopyTo(stream);
				w.Image = "/Images/" + newImageName;
			}
			w.CategoriId = createModel.CategoriId;
			w.WriterId = createModel.WriterId;
			w.AddDate = DateTime.Now;
			w.Title = createModel.Title;
			w.Description = createModel.Description;
			w.Tags = createModel.Tags;
			_myWriteService.TAdd(w);
			return RedirectToAction("AdMyWriteList");
		}
		[HttpGet]
		public IActionResult AdMyWriteUpdate(int id)
		{
			List<SelectListItem> categoryValue = (from x in _categoriService.TGetList()
												  select new SelectListItem
												  {
													  Text = x.CategoriTitle,
													  Value = x.CategoriId.ToString()

												  }).ToList();
			ViewBag.catValue = categoryValue;

			List<SelectListItem> writerValue = (from x in _writerService.TGetList()
												select new SelectListItem
												{
													Text = x.Name + x.Surname,
													Value = x.WriterId.ToString()

												}).ToList();
			ViewBag.writValue = writerValue;
			var values = _myWriteService.TGetByID(id);
			MyWriteUpdateModel mywriteUpdateModel = new MyWriteUpdateModel();
			mywriteUpdateModel.MyWriteId = values.MyWriteId;
			mywriteUpdateModel.Title = values.Title;
			mywriteUpdateModel.Description = values.Description;
			mywriteUpdateModel.Tags = values.Tags;
			mywriteUpdateModel.CategoriId = values.CategoriId;
			mywriteUpdateModel.WriterId = values.WriterId;
			return View(mywriteUpdateModel);
		}
		[HttpPost]
		public IActionResult AdMyWriteUpdate(MyWriteUpdateModel updateModel)
		{
			var values = _myWriteService.TGetByID(updateModel.MyWriteId);
			if (updateModel.Image != null)
			{
				var resource = Directory.GetCurrentDirectory();
				var extension = Path.GetExtension(updateModel.Image.FileName);
				var imageName = Guid.NewGuid() + extension;
				var saveLocation = resource + "/wwwroot/Images/" + imageName;
				var stream = new FileStream(saveLocation, FileMode.Create);
				updateModel.Image.CopyTo(stream);
				values.Image = "/Images/" + imageName;
			}
			values.CategoriId = updateModel.CategoriId;
			values.WriterId = updateModel.WriterId;
			values.Title = updateModel.Title;
			values.Description = updateModel.Description;
			values.Tags = updateModel.Tags;
			_myWriteService.TUpdate(values);

			return RedirectToAction("AdMyWriteList");
		}
		public ActionResult AdMyWriteDoFalse(int id)
		{
			var idser = _myWriteService.TGetByID(id);
			idser.Status = false;
			_myWriteService.TUpdate(idser);
			return RedirectToAction("AdMyWriteList");
		}
		public ActionResult AdMyWriteDoTrue(int id)
		{
			var idser = _myWriteService.TGetByID(id);
			idser.Status = true;
			_myWriteService.TUpdate(idser);
			return RedirectToAction("AdMyWriteList");
		}
	}
}
