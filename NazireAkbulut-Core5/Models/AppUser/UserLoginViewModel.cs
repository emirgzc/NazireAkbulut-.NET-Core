using System.ComponentModel.DataAnnotations;

namespace NazireAkbulut_Core5.Models.AppUser
{
	public class UserLoginViewModel
	{
		[Required(ErrorMessage = "Lütfen kullanıcı adınız giriniz.")]
		public string username { get; set; }
		[Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
		public string password { get; set; }
	}
}
