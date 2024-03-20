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
	public class FileTypeManager : IFileTypeService
	{
		private readonly IFileTypeDal _fileTypeDal;

		public FileTypeManager(IFileTypeDal fileTypeDal)
		{
			_fileTypeDal = fileTypeDal;
		}

		public List<FileType> FileTypeListForStatus()
		{
			return _fileTypeDal.FileTypeListForStatus();
		}

		public List<FileType> GetByFilterList(Expression<Func<FileType, bool>> filter)
		{
			throw new NotImplementedException();
		}

        public int ListCount()
        {
            throw new NotImplementedException();
        }

        public void TAdd(FileType t)
		{
			_fileTypeDal.Insert(t);
		}

		public void TDelete(FileType t)
		{
			_fileTypeDal.Delete(t);
		}

		public FileType TGetByID(int id)
		{
			return _fileTypeDal.GetById(id);
		}

		public List<FileType> TGetList()
		{
			return _fileTypeDal.GetList();
		}

		public void TUpdate(FileType t)
		{
			_fileTypeDal.Update(t);
		}
	}
}
