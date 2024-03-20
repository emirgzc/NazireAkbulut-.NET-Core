﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface IContactDal : IGenericDal<Contact>
	{
		List<Contact> ContactDetail(int id);
		List<Contact> ContactListByDate();
	}
}