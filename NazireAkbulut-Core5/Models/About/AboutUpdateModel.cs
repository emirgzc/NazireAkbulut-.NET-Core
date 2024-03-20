using Microsoft.AspNetCore.Http;

namespace NazireAkbulut_Core5.Models.About
{
	public class AboutUpdateModel
	{
		public int AboutId { get; set; }
		public IFormFile AboutImage { get; set; }
		public string AboutTitle { get; set; }
		public string AboutDescription { get; set; }
	}
}
