using Microsoft.AspNetCore.Http;

namespace NazireAkbulut_Core5.Models.Writer
{
	public class WriterCreateModel
	{
		public int WriterId { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public IFormFile Image { get; set; }
		public string ShortTrailer { get; set; }
		public string FacebookLink { get; set; }
		public string TwitterLink { get; set; }
		public string InstagramLink { get; set; }
		public string LinkedinLink { get; set; }
		public string YoutubeLink { get; set; }
		public bool Status { get; set; }
	}
}
