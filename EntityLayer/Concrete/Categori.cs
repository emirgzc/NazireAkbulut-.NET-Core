using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Categori
	{
		public int CategoriId { get; set; }
		public string CategoriTitle { get; set; }
		public bool CategoriStatus { get; set; }
		public List<MyWrite> MyWrites { get; set; }
	}

}

