using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class FileType
	{
		public int FileTypeId { get; set; }
		public string FileTypeTitle { get; set; }
		public bool Status { get; set; }
		public List<FileNazire> FileNazires { get; set; }
	}

}

