﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EfSocialMediaRepository : GenericRepository<SocialMedia>, ISocialMediaDal
	{
		public List<SocialMedia> SocialMediaListForStatus()
		{
			using (var c = new Context())
			{
				return c.SocialMedias.Where(x => x.Status).ToList();
			}
		}
	}
}
