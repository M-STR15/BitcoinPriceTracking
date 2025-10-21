namespace BitcoinPriceTracking.BE.Shared.Models.DTOs
{
	public class CryptoDataNoteBaseDTO : CryptoDataNoteEditDTO
	{
		public virtual int Id { get; set; }
		public virtual DateTime TimeStamp { get; set; }
		public virtual int CryptoDataId { get; set; }
	}
}