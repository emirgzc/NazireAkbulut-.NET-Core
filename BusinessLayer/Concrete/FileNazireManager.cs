using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class FileNazireManager : IFileNazireService
	{
		private readonly IFileNazireDal _fileNazireDal;

		public FileNazireManager(IFileNazireDal fileNazireDal)
		{
			_fileNazireDal = fileNazireDal;
		}

        public int FileNazireFalseCount()
        {
			return _fileNazireDal.GetList().Where(x => x.Status == false).Count();
        }

        public List<FileNazire> FileNazireGetAll()
        {
			return _fileNazireDal.FileNazireGetAll();
        }

        public List<FileNazire> FileNazireToFileType(int id)
        {
			return _fileNazireDal.FileNazireToFileType(id);
        }

        public List<FileNazire> GetByFilterList(Expression<Func<FileNazire, bool>> filter)
		{
			throw new NotImplementedException();
		}

        public int ListCount()
        {
            return _fileNazireDal.GetList().Where(x => x.Status).Count();
        }

        public void TAdd(FileNazire t)
		{
			_fileNazireDal.Insert(t);
		}

		public void TDelete(FileNazire t)
		{
			_fileNazireDal.Delete(t);
		}

		public FileNazire TGetByID(int id)
		{
			return _fileNazireDal.GetById(id);
		}

		public List<FileNazire> TGetList()
		{
			return _fileNazireDal.GetList();
		}

		public void TUpdate(FileNazire t)
		{
			_fileNazireDal.Update(t);
		}
	}
}
