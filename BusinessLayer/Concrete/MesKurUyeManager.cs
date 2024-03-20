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
	public class MesKurUyeManager : IMesKurUyeService
	{
		private readonly IMesKurUyeDal _mesKurUyeDal;

		public MesKurUyeManager(IMesKurUyeDal mesKurUyeDal)
		{
			_mesKurUyeDal = mesKurUyeDal;
		}

		public List<MesKurUye> GetByFilterList(Expression<Func<MesKurUye, bool>> filter)
		{
			throw new NotImplementedException();
		}

        public int ListCount()
        {
            throw new NotImplementedException();
        }

        public List<MesKurUye> MesKurUyeListForStatus()
		{
			return _mesKurUyeDal.MesKurUyeListForStatus();
		}

		public void TAdd(MesKurUye t)
		{
			_mesKurUyeDal.Insert(t);
		}

		public void TDelete(MesKurUye t)
		{
			_mesKurUyeDal.Delete(t);
		}

		public MesKurUye TGetByID(int id)
		{
			return _mesKurUyeDal.GetById(id);
		}

		public List<MesKurUye> TGetList()
		{
			return _mesKurUyeDal.GetList();
		}

		public void TUpdate(MesKurUye t)
		{
			_mesKurUyeDal.Update(t);
		}
	}
}
