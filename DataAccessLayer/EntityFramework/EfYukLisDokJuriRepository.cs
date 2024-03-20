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
	public class EfYukLisDokJuriRepository : GenericRepository<YukLisDokJuri>, IYukLisDokJuriDal
	{
		public List<YukLisDokJuri> YukLisDokJuriListForStatus()
		{
			using (var c = new Context())
			{
				return c.YukLisDokJuris.Where(z => z.Status).ToList();
			}
		}
	}
}
