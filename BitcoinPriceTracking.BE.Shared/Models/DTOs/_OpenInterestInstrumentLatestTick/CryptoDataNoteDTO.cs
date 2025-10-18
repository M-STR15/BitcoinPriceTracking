namespace BitcoinPriceTracking.BE.Shared.Models.DTOs
{
	public class CryptoDataNoteDTO : CryptoDataNoteBaseDTO
	{
		public virtual CryptoDataBaseDTO CryptoData { get; set; } = null!;
	}
}
