namespace BitcoinPriceTracking.BE.Shared.Models.DTOs
{
	public class ErrDto
	{
		public int type { get; set; }
		public string message { get; set; }
		public Other_InfoDto other_info { get; set; }
	}
}
