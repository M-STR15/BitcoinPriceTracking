using BitcoinPriceTracking.BE.DB.DataAccess;
using BitcoinPriceTracking.BE.DB.Models.Entities;
using BitcoinPriceTracking.BE.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BitcoinPriceTracking.BE.DB.Repositories
{
	public class CoindeskRepositories<T> : aRepository<T>, ICoindeskRepositories where T : MainDatacontext
	{

		public CoindeskRepositories(Func<T> contextFactory) : base(contextFactory)
		{

		}

		public async Task<ICryptoData> GetLastCryptoDataAsync()
		{
			try
			{
				var context = _contextFactory();
				return await context.CryptoDatas.LastOrDefaultAsync();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public async Task<ICryptoData> AddCryptoDataAsync(ICryptoData cryptoData)
		{
			try
			{
				var data = (CryptoData)cryptoData;
				var context = _contextFactory();
				await context.CryptoDatas.AddAsync(data);
				await context.SaveChangesAsync();

				return cryptoData;
			}
			catch (Exception ex)
			{
				var test = ex;
				throw;
			}
		}
	}
}
