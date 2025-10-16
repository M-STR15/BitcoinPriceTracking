using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinPriceTracking.BE.BusinessLogic.Models
{
	public class ErrDto
	{
		public int type { get; set; }
		public string message { get; set; }
		public Other_InfoDto other_info { get; set; }
	}
}
