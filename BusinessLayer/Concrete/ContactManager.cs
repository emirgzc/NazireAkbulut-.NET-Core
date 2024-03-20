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
	public class ContactManager : IContactService
	{
		private readonly IContactDal _contactDal;

		public ContactManager(IContactDal contactDal)
		{
			_contactDal = contactDal;
		}

		public List<Contact> ContactDetail(int id)
		{
			return _contactDal.ContactDetail(id);
		}

		public List<Contact> ContactListByDate()
		{
			return _contactDal.ContactListByDate();
		}

		public List<Contact> GetByFilterList(Expression<Func<Contact, bool>> filter)
		{
			throw new NotImplementedException();
		}

        public int ListCount()
        {
			return _contactDal.GetList().Count();
        }

        public void TAdd(Contact t)
		{
			_contactDal.Insert(t);
		}

		public void TDelete(Contact t)
		{
			_contactDal.Delete(t);
		}

		public Contact TGetByID(int id)
		{
			return _contactDal.GetById(id);
		}

		public List<Contact> TGetList()
		{
			return _contactDal.GetList();
		}

		public void TUpdate(Contact t)
		{
			_contactDal.Update(t);
		}
	}
}
