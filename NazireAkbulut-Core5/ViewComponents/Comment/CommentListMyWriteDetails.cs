using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace NazireAkbulut_Core5.ViewComponents.Comment
{
	public class CommentListMyWriteDetails : ViewComponent
	{
		private readonly ICommentService _commentService;

		public CommentListMyWriteDetails(ICommentService commentService)
		{
			_commentService = commentService;
		}

		public IViewComponentResult Invoke(int id)
		{
			var values = _commentService.CommentListToMyWrite(id);
			return View(values);
		}
	}
}
