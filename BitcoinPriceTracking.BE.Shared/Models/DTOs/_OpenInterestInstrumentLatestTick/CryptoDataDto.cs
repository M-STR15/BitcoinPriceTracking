namespace BitcoinPriceTracking.BE.Shared.Models.DTOs
{
	public class CryptoDataDTO : CryptoDataBaseDTO
	{
		public virtual CryptoDataNoteBaseDTO? CryptoDataNoteBase { get; set; }
	}
}