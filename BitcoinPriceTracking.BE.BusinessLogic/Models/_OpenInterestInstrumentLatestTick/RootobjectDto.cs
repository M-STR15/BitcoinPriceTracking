namespace BitcoinPriceTracking.BE.BusinessLogic.Models
{
	public class RootobjectDto
	{
		public Dictionary<string, CryptoDataDto> Data { get; set; }
		public ErrDto Err { get; set; }
	}
}
