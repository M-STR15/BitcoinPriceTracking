namespace BitcoinPriceTracking.Models.MVs
{
	public class CryptoDataReportMV
	{
		public string Note { get; set; } = string.Empty;
		public DateTime TimeStamp { get; set; }
		public int CryptoDataNoteId { get; set; }
		public int CryptoDataId { get; set; }
		public double PRICE { get; set; }
	}
}