namespace BitcoinPriceTracking.BE.Shared.Models.DTOs
{
	public class ErrDTO
	{
		public int type { get; set; }
		public string message { get; set; }
		public Other_InfoDTO other_info { get; set; }
	}
}
