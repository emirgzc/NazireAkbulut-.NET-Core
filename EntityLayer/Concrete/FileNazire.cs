using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class FileNazire
	{
		public int FileNazireId { get; set; }
		public string File { get; set; }
		public string FileDescription { get; set; }
		public bool Status { get; set; }
		public int FileTypeId { get; set; }
		public FileType FileType { get; set; }
	}
}


