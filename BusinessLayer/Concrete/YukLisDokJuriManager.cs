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
	public class YukLisDokJuriManager : IYukLisDokJuriService
	{
		private readonly IYukLisDokJuriDal _yukLisDokJuriDal;

		public YukLisDokJuriManager(IYukLisDokJuriDal yukLisDokJuriDal)
		{
			_yukLisDokJuriDal = yukLisDokJuriDal;
		}

		public List<YukLisDokJuri> GetByFilterList(Expression<Func<YukLisDokJuri, bool>> filter)
		{
			throw new NotImplementedException();
		}

        public int ListCount()
        {
            throw new NotImplementedException();
        }

        public void TAdd(YukLisDokJuri t)
		{
			_yukLisDokJuriDal.Insert(t);
		}

		public void TDelete(YukLisDokJuri t)
		{
			_yukLisDokJuriDal.Delete(t);
		}

		public YukLisDokJuri TGetByID(int id)
		{
			return _yukLisDokJuriDal.GetById(id);
		}

		public List<YukLisDokJuri> TGetList()
		{
			return _yukLisDokJuriDal.GetList();
		}

		public void TUpdate(YukLisDokJuri t)
		{
			_yukLisDokJuriDal.Update(t);
		}

		public List<YukLisDokJuri> YukLisDokJuriListForStatus()
		{
			return _yukLisDokJuriDal.YukLisDokJuriListForStatus();
		}
	}
}
