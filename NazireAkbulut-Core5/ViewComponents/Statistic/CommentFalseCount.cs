using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.ViewComponents.Statistic
{
    public class CommentFalseCount : ViewComponent
    {
        private readonly ICommentService _commentService;

        public CommentFalseCount(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _commentService.CommentFalseCount();
            ViewBag.count = values;
            return View();
        }
    }
}
