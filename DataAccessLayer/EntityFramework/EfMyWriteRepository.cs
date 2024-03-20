using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EfMyWriteRepository : GenericRepository<MyWrite>, IMyWriteDal
	{
		public string MyWriteCategoryName(int id)
		{
			using (var c = new Context())
			{
				return c.MyWrites.Include(c => c.Categori).Where(z => z.CategoriId == id).Select(c => c.Categori.CategoriTitle).FirstOrDefault();
			}
		}

        public List<MyWrite> MyWriteDetails(int id)
		{
			using (var c = new Context())
			{
				return c.MyWrites.Include(x => x.Writer).Include(z => z.Categori).Where(x => x.MyWriteId == id).ToList();
			}
		}

		public List<MyWrite> MyWriteListByWriter(int id)
		{
			using (var c = new Context())
			{
				return c.MyWrites.Include(x => x.Writer).Include(z => z.Categori).Where(x => x.WriterId == id && x.Status).OrderByDescending(z => z.AddDate).ToList();
			}
		}

		public List<MyWrite> MyWriteListForDetailWithCategori(int id)
		{
			using (var c = new Context())
			{
				return c.MyWrites.Include(c => c.Categori).Include(w => w.Writer).OrderByDescending(x => x.AddDate).Where(z => z.CategoriId == id && z.Status).Take(4).ToList();
			}
		}

		public List<MyWrite> MyWriteListGetAll()
		{
			using (var c = new Context())
			{
				return c.MyWrites.Include(x => x.Writer).Include(z => z.Categori).OrderByDescending(c => c.AddDate).ToList();
			}
		}

		public List<MyWrite> MyWriteListGetAllWithStatus()
		{
			using (var c = new Context())
			{
				return c.MyWrites.Include(x => x.Writer).Include(z => z.Categori).Where(z => z.Status).OrderByDescending(c => c.AddDate).ToList();
			}
		}

		public List<MyWrite> MyWriteListHomePageWithCategori(int id, int count)
		{
			using (var c = new Context())
			{
				return c.MyWrites.Include(x => x.Writer).Include(z => z.Categori).Where(x => x.CategoriId == id && x.Status).OrderByDescending(c => c.AddDate).Take(count).ToList();
			}
		}

		public List<MyWrite> MyWriteListPopular()
		{
			using (var c = new Context())
			{
				return c.MyWrites.Where(z => z.Status).Take(4).ToList();
			}
		}

		public List<MyWrite> MyWriteListTo3LastPost()
		{
			using (var c = new Context())
			{
				return c.MyWrites.Include(x => x.Writer).Include(z => z.Categori).Where(z => z.Status).OrderByDescending(c => c.AddDate).Take(3).ToList();
			}
		}

		public List<MyWrite> MyWriteListToHomePageLast()
		{
			using (var c = new Context())
			{
				return c.MyWrites.Include(x => x.Writer).Include(z => z.Categori).OrderByDescending(c => c.AddDate).Where(z => z.Status).Take(1).ToList();
			}
		}

		public List<MyWrite> MyWriteListWithCategory(int id)
		{
			using (var c = new Context())
			{
				return c.MyWrites.Include(c => c.Categori).Include(w => w.Writer).OrderByDescending(x => x.AddDate).Where(z => z.CategoriId == id && z.Status).ToList();
			}
		}

		public List<MyWrite> MyWriteToHomePageLastList()
		{
			using (var c = new Context())
			{
				return c.MyWrites.Include(x => x.Writer).Include(z => z.Categori).OrderByDescending(c => c.AddDate).Where(z => z.Status).Take(4).ToList();
			}
		}
	}
}
