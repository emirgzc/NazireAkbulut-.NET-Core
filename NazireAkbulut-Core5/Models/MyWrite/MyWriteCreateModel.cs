using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using System;

namespace NazireAkbulut_Core5.Models.MyWrite
{
	public class MyWriteCreateModel
	{
		public int MyWriteId { get; set; }
		public string Title { get; set; }
		public DateTime AddDate { get; set; }
		public IFormFile Image { get; set; }
		public string Description { get; set; }
		public string Tags { get; set; }
		public bool Status { get; set; }
		public int CategoriId { get; set; }
		public int WriterId { get; set; }
	}
}
