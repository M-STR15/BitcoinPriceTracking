namespace BitcoinPriceTracking.BE.Shared.Services
{
	public static class BtcConvertor
	{
		public static double ConvertCryptoDataToCzk(double btcEucPrice, double eucCzkPrice)
		{
			return btcEucPrice * eucCzkPrice;
		}
	}
}