﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class MesKurUye
	{
		public int MesKurUyeId { get; set; }
		public string Title { get; set; }
		public string ShortContent { get; set; }
		public string Date { get; set; }
		public bool Status { get; set; }
	}
}