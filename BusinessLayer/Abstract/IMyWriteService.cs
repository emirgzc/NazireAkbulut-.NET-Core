using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IMyWriteService : IGenericService<MyWrite>
	{
		List<MyWrite> MyWriteListToHomePageLast();
		List<MyWrite> MyWriteListGetAllWithStatus();
		List<MyWrite> MyWriteListGetAll();
		List<MyWrite> MyWriteListPopular();
		List<MyWrite> MyWriteDetails(int id);
		string MyWriteCategoryName(int id);
		int MyWriteFalseCount();
		List<MyWrite> MyWriteListWithCategory(int id);
		List<MyWrite> MyWriteListByWriter(int id);
		List<MyWrite> MyWriteListForDetailWithCategori(int id);
		List<MyWrite> MyWriteToHomePageLastList();
		List<MyWrite> MyWriteListTo3LastPost();
		List<MyWrite> MyWriteListHomePageWithCategori(int id, int count);
	}
}
