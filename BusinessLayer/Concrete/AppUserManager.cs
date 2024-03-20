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
	public class AppUserManager : IAppUserService
	{
		private readonly IAppUserDal _appUserDal;

		public AppUserManager(IAppUserDal appUserDal)
		{
			_appUserDal = appUserDal;
		}

		public List<AppUser> GetByFilterList(Expression<Func<AppUser, bool>> filter)
		{
			throw new NotImplementedException();
		}

        public int ListCount()
        {
            throw new NotImplementedException();
        }

        public void TAdd(AppUser t)
		{
			_appUserDal.Insert(t);
		}

		public void TDelete(AppUser t)
		{
			_appUserDal.Delete(t);
		}

		public AppUser TGetByID(int id)
		{
			return _appUserDal.GetById(id);
		}

		public List<AppUser> TGetList()
		{
			return _appUserDal.GetList();
		}

		public void TUpdate(AppUser t)
		{
			_appUserDal.Update(t);
		}
	}
}
