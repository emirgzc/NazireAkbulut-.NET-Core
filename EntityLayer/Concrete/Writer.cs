using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Writer
	{
		public int WriterId { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Image { get; set; }
		public string ShortTrailer { get; set; }
		public string FacebookLink { get; set; }
		public string TwitterLink { get; set; }
		public string InstagramLink { get; set; }
		public string LinkedinLink { get; set; }
		public string YoutubeLink { get; set; }
		public bool Status { get; set; }
		public List<MyWrite> MyWrites { get; set; }
	}

}