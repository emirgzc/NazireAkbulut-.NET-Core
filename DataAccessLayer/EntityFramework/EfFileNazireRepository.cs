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
    public class EfFileNazireRepository : GenericRepository<FileNazire>, IFileNazireDal
    {
        public List<FileNazire> FileNazireGetAll()
        {
            using (var c = new Context())
            {
                return c.FileNazires.Include(c => c.FileType).ToList();
            }
        }

        public List<FileNazire> FileNazireToFileType(int id)
        {
            using (var c = new Context())
            {
                return c.FileNazires.Include(c => c.FileType).Where(z => z.FileTypeId == id && z.Status).ToList();
            }
        }
    }
}
