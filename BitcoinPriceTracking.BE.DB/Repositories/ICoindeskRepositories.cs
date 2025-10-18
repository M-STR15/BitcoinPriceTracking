using BitcoinPriceTracking.BE.Shared.Interfaces.Models;

namespace BitcoinPriceTracking.BE.DB.Repositories
{
	public interface ICoindeskRepositories
	{
		Task<ICryptoData> AddCryptoDataAsync(ICryptoData cryptoData);
		Task<ICryptoData> GetLastCryptoDataAsync();
	}
}