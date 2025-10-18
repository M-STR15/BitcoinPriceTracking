namespace BitcoinPriceTracking.BE.Shared.Models.DTOs
{
	public class CryptoDataNoteBaseDTO
	{
		public int Id { get; set; }
		public string Note { get; set; } = string.Empty;
		public DateTime TimeStamp { get; set; }
		public int CryptoDataId { get; set; }
	}
}
