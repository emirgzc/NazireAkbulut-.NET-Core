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
    public class MyWriteManager : IMyWriteService
    {
        private readonly IMyWriteDal _myWriteDal;

        public MyWriteManager(IMyWriteDal myWriteDal)
        {
            _myWriteDal = myWriteDal;
        }

        public List<MyWrite> GetByFilterList(Expression<Func<MyWrite, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public int ListCount()
        {
            return _myWriteDal.GetList().Where(x => x.Status).ToList().Count();
        }

        public string MyWriteCategoryName(int id)
        {
            return _myWriteDal.MyWriteCategoryName(id);
        }

        public List<MyWrite> MyWriteDetails(int id)
        {
            return _myWriteDal.MyWriteDetails(id);
        }

        public int MyWriteFalseCount()
        {
            return _myWriteDal.GetList().Where(x => x.Status == false).ToList().Count();
        }

        public List<MyWrite> MyWriteListByWriter(int id)
        {
            return _myWriteDal.MyWriteListByWriter(id);
        }

        public List<MyWrite> MyWriteListForDetailWithCategori(int id)
        {
            return _myWriteDal.MyWriteListForDetailWithCategori(id);
        }

        public List<MyWrite> MyWriteListGetAll()
        {
            return _myWriteDal.MyWriteListGetAll();
        }

        public List<MyWrite> MyWriteListGetAllWithStatus()
        {
            return _myWriteDal.MyWriteListGetAllWithStatus();
        }

        public List<MyWrite> MyWriteListHomePageWithCategori(int id, int count)
        {
            return _myWriteDal.MyWriteListHomePageWithCategori(id, count);
        }

        public List<MyWrite> MyWriteListPopular()
        {
            return _myWriteDal.MyWriteListPopular();
        }

        public List<MyWrite> MyWriteListTo3LastPost()
        {
            return _myWriteDal.MyWriteListTo3LastPost();
        }

        public List<MyWrite> MyWriteListToHomePageLast()
        {
            return _myWriteDal.MyWriteListToHomePageLast();
        }

        public List<MyWrite> MyWriteListWithCategory(int id)
        {
            return _myWriteDal.MyWriteListWithCategory(id);
        }

        public List<MyWrite> MyWriteToHomePageLastList()
        {
            return _myWriteDal.MyWriteToHomePageLastList();
        }

        public void TAdd(MyWrite t)
        {
            _myWriteDal.Insert(t);
        }

        public void TDelete(MyWrite t)
        {
            _myWriteDal.Delete(t);
        }

        public MyWrite TGetByID(int id)
        {
            return _myWriteDal.GetById(id);
        }

        public List<MyWrite> TGetList()
        {
            return _myWriteDal.GetList();
        }

        public void TUpdate(MyWrite t)
        {
            _myWriteDal.Update(t);
        }
    }
}
