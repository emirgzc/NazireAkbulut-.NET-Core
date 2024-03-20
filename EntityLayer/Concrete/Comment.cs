using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Comment
	{
		public int CommentId { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public DateTime CommentDate { get; set; }
		public string Email { get; set; }
		public string Content { get; set; }
		public bool Status { get; set; }
		public int MyWriteId { get; set; }
		public MyWrite MyWrite { get; set; }
	}

}

