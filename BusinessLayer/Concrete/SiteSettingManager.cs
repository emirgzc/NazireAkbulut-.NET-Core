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
	public class SiteSettingManager : ISiteSettingService
	{
		private readonly ISiteSettingDal _siteSettingDal;

		public SiteSettingManager(ISiteSettingDal siteSettingDal)
		{
			_siteSettingDal = siteSettingDal;
		}

		public List<SiteSetting> GetByFilterList(Expression<Func<SiteSetting, bool>> filter)
		{
			throw new NotImplementedException();
		}

        public int ListCount()
        {
            throw new NotImplementedException();
        }

        public void TAdd(SiteSetting t)
		{
			_siteSettingDal.Insert(t);
		}

		public void TDelete(SiteSetting t)
		{
			_siteSettingDal.Delete(t);
		}

		public SiteSetting TGetByID(int id)
		{
			return _siteSettingDal.GetById(id);
		}

		public List<SiteSetting> TGetList()
		{
			return _siteSettingDal.GetList();
		}

		public void TUpdate(SiteSetting t)
		{
			_siteSettingDal.Update(t);
		}
	}
}
