using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NazireAkbulut_Core5.Models.MyWrite;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
using X.PagedList;
using NazireAkbulut_Core5.Models.Writer;
using Microsoft.AspNetCore.Authorization;

namespace NazireAkbulut_Core5.Controllers
{
	public class WriterController : Controller
	{
		private readonly IWriterService _writerService;
		private readonly IMyWriteService _myWriteService;

		public WriterController(IWriterService writerService, IMyWriteService myWriteService)
		{
			_writerService = writerService;
			_myWriteService = myWriteService;
		}
        [AllowAnonymous]
        public IActionResult Index(int id, int page = 1)
		{
			ViewBag.writerId = id;
			var values = _myWriteService.MyWriteListByWriter(id).ToPagedList(page, 14);
			return View(values);
		}
		public IActionResult AdWriterList(int page = 1)
		{
			var values = _writerService.TGetList().ToPagedList(page, 10);
			return View(values);
		}
		[HttpGet]
		public IActionResult AdWriterAdd()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AdWriterAdd(WriterCreateModel createModel)
		{
			Writer w = new Writer();
			if (createModel.Image != null)
			{
				var extension = Path.GetExtension(createModel.Image.FileName);
				var newImageName = Guid.NewGuid() + extension;
				var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/", newImageName);
				var stream = new FileStream(location, FileMode.Create);
				createModel.Image.CopyTo(stream);
				w.Image = "/Images/" + newImageName;
			}
			w.Name = createModel.Name;
			w.Surname = createModel.Surname;
			w.FacebookLink = createModel.FacebookLink;
			w.TwitterLink = createModel.TwitterLink;
			w.InstagramLink = createModel.InstagramLink;
			w.LinkedinLink = createModel.LinkedinLink;
			w.YoutubeLink = createModel.YoutubeLink;
			w.ShortTrailer = createModel.ShortTrailer;
			w.Status = true;
			_writerService.TAdd(w);
			return RedirectToAction("AdWriterList");
		}
		[HttpGet]
		public IActionResult AdWriteUpdate(int id)
		{
			var values = _writerService.TGetByID(id);
			WriterUpdateModel writerUpdateModel = new WriterUpdateModel();
			writerUpdateModel.WriterId = values.WriterId;
			writerUpdateModel.Name = values.Name;
			writerUpdateModel.Surname = values.Surname;
			writerUpdateModel.FacebookLink = values.FacebookLink;
			writerUpdateModel.TwitterLink = values.TwitterLink;
			writerUpdateModel.InstagramLink = values.InstagramLink;
			writerUpdateModel.LinkedinLink = values.LinkedinLink;
			writerUpdateModel.YoutubeLink = values.YoutubeLink;
			writerUpdateModel.ShortTrailer = values.ShortTrailer;
			return View(writerUpdateModel);
		}
		[HttpPost]
		public IActionResult AdWriteUpdate(WriterUpdateModel updateModel)
		{
			var values = _writerService.TGetByID(updateModel.WriterId);
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
			values.Name = updateModel.Name;
			values.Surname = updateModel.Surname;
			values.FacebookLink = updateModel.FacebookLink;
			values.TwitterLink = updateModel.TwitterLink;
			values.InstagramLink = updateModel.InstagramLink;
			values.LinkedinLink = updateModel.LinkedinLink;
			values.YoutubeLink = updateModel.YoutubeLink;
			values.ShortTrailer = updateModel.ShortTrailer;
			_writerService.TUpdate(values);

			return RedirectToAction("AdWriterList");
		}
	}
}
