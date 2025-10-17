using BitcoinPriceTracking.BE.Shared.Shared.DTOs;

namespace BitcoinPriceTracking.BE.Shared.Models.DTOs
{
	public class RootobjectDto
	{
		public Dictionary<string, CryptoDataDto> Data { get; set; }
		public ErrDto Err { get; set; }
	}
}
