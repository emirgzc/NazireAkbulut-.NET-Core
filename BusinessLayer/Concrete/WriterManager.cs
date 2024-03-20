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
	public class WriterManager : IWriterService
	{
		private readonly IWriterDal _writerDal;

		public WriterManager(IWriterDal writerDal)
		{
			_writerDal = writerDal;
		}

		public List<Writer> GetByFilterList(Expression<Func<Writer, bool>> filter)
		{
			throw new NotImplementedException();
		}

        public int ListCount()
        {
			return _writerDal.GetList().Count();
        }

        public void TAdd(Writer t)
		{
			_writerDal.Insert(t);
		}

		public void TDelete(Writer t)
		{
			_writerDal.Delete(t);
		}

		public Writer TGetByID(int id)
		{
			return _writerDal.GetById(id);
		}

		public List<Writer> TGetList()
		{
			return _writerDal.GetList();
		}

		public void TUpdate(Writer t)
		{
			_writerDal.Update(t);
		}

		public List<Writer> WriteGetWithMyWriter(int id)
		{
			return _writerDal.WriteGetWithMyWriter(id);
		}

    }
}
