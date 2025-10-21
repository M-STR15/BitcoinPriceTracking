namespace BitcoinPriceTracking.BE.Shared.Models.DTOs
{
	public class RootobjectDTO
	{
		public Dictionary<string, CryptoDataBaseDTO> Data { get; set; }
		public ErrDTO Err { get; set; }
	}
}