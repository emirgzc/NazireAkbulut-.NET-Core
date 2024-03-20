using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface IFileNazireDal : IGenericDal<FileNazire>
	{
        List<FileNazire> FileNazireToFileType(int id);
        List<FileNazire> FileNazireGetAll();
    }
}
