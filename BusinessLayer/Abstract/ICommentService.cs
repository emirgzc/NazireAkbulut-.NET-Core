using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ICommentService : IGenericService<Comment>
	{
		List<Comment> CommentListToMyWrite(int id);
		int CommentFalseCount();
		List<Comment> CommentListWithMyWrite();
		List<Comment> CommentListWithMyWrite(int id);
	}
}
