using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IFileNazireService : IGenericService<FileNazire>
	{
		List<FileNazire> FileNazireToFileType(int id);
		List<FileNazire> FileNazireGetAll();
		int FileNazireFalseCount();

    }
}
