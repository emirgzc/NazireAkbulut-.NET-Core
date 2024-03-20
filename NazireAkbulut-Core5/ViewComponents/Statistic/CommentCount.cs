using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.ViewComponents.Statistic
{
    public class CommentCount : ViewComponent
    {
        private readonly ICommentService _commentService;

        public CommentCount(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _commentService.ListCount();
            ViewBag.count = values;
            return View();
        }
    }
}
