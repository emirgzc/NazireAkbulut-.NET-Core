using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
	public static class EfOthers
	{
		public static void ContainerDependencies(this IServiceCollection services)
		{
			services.AddScoped<ICategoriService, CategoriManager>();
			services.AddScoped<ICategoriDal, EfCategoriRepository>();
			
			services.AddScoped<IMyWriteService, MyWriteManager>();
			services.AddScoped<IMyWriteDal, EfMyWriteRepository>();
			
			services.AddScoped<IAboutService, AboutManager>();
			services.AddScoped<IAboutDal, EfAboutRepository>();

			services.AddScoped<IContactService, ContactManager>();
			services.AddScoped<IContactDal, EfContactRepository>();

			services.AddScoped<ISiteSettingService, SiteSettingManager>();
			services.AddScoped<ISiteSettingDal, EfSiteSettingRepository>();
			
			services.AddScoped<IFileNazireService, FileNazireManager>();
			services.AddScoped<IFileNazireDal, EfFileNazireRepository>();
			
			services.AddScoped<IFileTypeService, FileTypeManager>();
			services.AddScoped<IFileTypeDal, EfFileTypeRepository>();

			services.AddScoped<ISocialMediaService, SocialMediaManager>();
			services.AddScoped<ISocialMediaDal, EfSocialMediaRepository>();
			
			services.AddScoped<IWriterService, WriterManager>();
			services.AddScoped<IWriterDal, EfWriterRepository>();

			services.AddScoped<ICommentService, CommentManager>();
			services.AddScoped<ICommentDal, EfCommentRepository>();

			services.AddScoped<IMesKurUyeService, MesKurUyeManager>();
			services.AddScoped<IMesKurUyeDal, EfMesKurUyeRepository>();

            services.AddScoped<IYukLisDokJuriService, YukLisDokJuriManager>();
            services.AddScoped<IYukLisDokJuriDal, EfYukLisDokJuriRepository>();

			services.AddScoped<IAppUserService, AppUserManager>();
			services.AddScoped<IAppUserDal, EfAppUserRepository>();
		}
	}
}
