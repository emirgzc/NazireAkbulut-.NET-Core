using Microsoft.AspNetCore.Http;

namespace NazireAkbulut_Core5.Models.FileNazire
{
	public class FileNazireCreateModel
	{
		public int FileNazireId { get; set; }
		public IFormFile File { get; set; }
		public string FileDescription { get; set; }
		public bool Status { get; set; }
		public int FileTypeId { get; set; }
	}
}
