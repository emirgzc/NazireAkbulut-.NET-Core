using BusinessLayer.Abstract;
using DNTCaptcha.Core;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
using System;
using System.Drawing;
using X.PagedList;

namespace NazireAkbulut_Core5.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly IDNTCaptchaValidatorService _validatorService;
        private readonly DNTCaptchaOptions _captchaOptions;

        public CommentController(ICommentService commentService, IDNTCaptchaValidatorService validatorService, IOptions<DNTCaptchaOptions> captchaOptions)
        {
            _commentService = commentService;
            _validatorService = validatorService;
            _captchaOptions = captchaOptions == null ? throw new ArgumentNullException(nameof(captchaOptions)) : captchaOptions.Value;
        }
        [AllowAnonymous]
        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddComment(Comment comment)
        {
            if (ModelState.IsValid)
            {
                if (!_validatorService.HasRequestValidCaptchaEntry(Language.English, DisplayMode.ShowDigits))
                {
                    this.ModelState.AddModelError(_captchaOptions.CaptchaComponent.CaptchaInputName, "Lütfen doğrulama kodunu giriniz.");
                    TempData["AlertMessage"] = "Üzgünüz, yorumunuz gönderilirken bir hata oluştu. Lütfen daha sonra tekrar deneyin.";
                    return RedirectToAction("MyWriteDetail", "MyWrite", new { id = comment.MyWriteId });
                }
            }
            TempData["alertType"] = true;
            TempData["AlertMessage"] = "Yorumunuz başarıyla kaydedildi ve sistemimizde güvenle saklanıyor. Şimdi moderatörlerimizin onayını bekliyor ve en kısa sürede yayınlanacaktır. Katkınızı takdir ediyoruz ve içeriklerimizi keşfetmeye devam etmenizi öneriyoruz. Teşekkür ederiz!";
            comment.CommentDate = DateTime.Now;
            _commentService.TAdd(comment);
            return RedirectToAction("MyWriteDetail", "MyWrite", new { id = comment.MyWriteId });
        }
        public IActionResult AdCommentList(int page = 1)
        {
            var values = _commentService.CommentListWithMyWrite().ToPagedList(page, 8);
            return View(values);
        }
		public IActionResult AdCommentListForMyWrite(int id)
		{
			var values = _commentService.CommentListWithMyWrite(id);
			return View(values);
		}
		public ActionResult AdCommentDoFalse(int id)
        {
            var idser = _commentService.TGetByID(id);
            idser.Status = false;
            _commentService.TUpdate(idser);
            return RedirectToAction("AdCommentList");
        }
        public ActionResult AdCommentDoTrue(int id)
        {
            var idser = _commentService.TGetByID(id);
            idser.Status = true;
            _commentService.TUpdate(idser);
            return RedirectToAction("AdCommentList");
        }
    }
}
