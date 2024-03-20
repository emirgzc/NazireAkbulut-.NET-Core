using DataAccessLayer.Abstract;
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
    public class EfCommentRepository : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> CommentListToMyWrite(int id)
        {
            using (var c = new Context())
            {
                return c.Comments.Where(z => z.MyWriteId == id && z.Status).OrderByDescending(x => x.CommentDate).ToList();
            }
        }

        public List<Comment> CommentListWithMyWrite()
        {
            using (var c = new Context())
            {
                return c.Comments.Include(z => z.MyWrite).OrderByDescending(x => x.CommentDate).ToList();
            }
        }

		public List<Comment> CommentListWithMyWrite(int id)
		{
			using (var c = new Context())
			{
				return c.Comments.Include(z => z.MyWrite).Where(z => z.MyWriteId == id).OrderByDescending(x => x.CommentDate).ToList();
			}
		}
	}
}
