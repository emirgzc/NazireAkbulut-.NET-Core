using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
	public class Context : IdentityDbContext<AppUser, AppRole, int>
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=77.245.159.136\\MSSQLSERVER2019; initial catalog=nazireakbulutdb; user=nazireakbulut;password=Mg59e35u~");
		}
		public DbSet<About> Abouts { get; set; }
		public DbSet<Categori> Categories { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<FileNazire> FileNazires { get; set; }
		public DbSet<FileType> FileTypes { get; set; }
		public DbSet<MyWrite> MyWrites { get; set; }
		public DbSet<SocialMedia> SocialMedias { get; set; }
		public DbSet<Writer> Writers { get; set; }
		public DbSet<MesKurUye> MesKurUyes { get; set; }
		public DbSet<YukLisDokJuri> YukLisDokJuris { get; set; }
		public DbSet<SiteSetting> SiteSettings { get; set; }
	}
}
