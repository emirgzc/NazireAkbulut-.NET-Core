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
	public class CategoriManager : ICategoriService
	{
		private readonly ICategoriDal _categoriDal;

		public CategoriManager(ICategoriDal categoriDal)
		{
			_categoriDal = categoriDal;
		}

        public List<Categori> CategoryListForStatus()
		{
			return _categoriDal.CategoryListForStatus();
		}

		public List<Categori> GetByFilterList(Expression<Func<Categori, bool>> filter)
		{
			throw new NotImplementedException();
		}

        public int ListCount()
        {
			return _categoriDal.GetList().Count();
        }

        public void TAdd(Categori t)
		{
			_categoriDal.Insert(t);
		}

		public void TDelete(Categori t)
		{
			_categoriDal.Delete(t);
		}

		public Categori TGetByID(int id)
		{
			return _categoriDal.GetById(id);
		}

		public List<Categori> TGetList()
		{
			return _categoriDal.GetList();
		}

		public void TUpdate(Categori t)
		{
			_categoriDal.Update(t);
		}
	}
}
