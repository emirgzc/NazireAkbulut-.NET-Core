using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EfCategoriRepository : GenericRepository<Categori>, ICategoriDal
	{

        public List<Categori> CategoryListForStatus()
		{
			using (var c = new Context())
			{
				return c.Categories.Where(z => z.CategoriStatus).ToList();
			}
		}
	}
}
