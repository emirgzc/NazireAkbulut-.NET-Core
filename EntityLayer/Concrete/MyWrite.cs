using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class MyWrite
	{
		public int MyWriteId { get; set; }
		public string Title { get; set; }
		public DateTime AddDate { get; set; }
		public string Image { get; set; }
		public string Description { get; set; }
		public string Tags { get; set; }
		public bool Status { get; set; }
		public int CategoriId { get; set; }
		public Categori Categori { get; set; }
		public int WriterId { get; set; }
		public Writer Writer { get; set; }
		public List<Comment> Comments { get; set; }
	}

}
