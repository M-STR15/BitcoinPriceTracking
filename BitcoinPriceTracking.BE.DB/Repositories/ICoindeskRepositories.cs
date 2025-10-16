using BitcoinPriceTracking.BE.Shared.Models;

namespace BitcoinPriceTracking.BE.DB.Repositories
{
	public interface ICoindeskRepositories
	{
		Task<ICryptoData> AddCryptoDataAsync(ICryptoData cryptoData);
		Task<ICryptoData> GetLastCryptoDataAsync();
	}
}