using BitcoinPriceTracking.BE.DB.DataAccess;
using BitcoinPriceTracking.BE.DB.Models.Entities;
using BitcoinPriceTracking.BE.Shared.Interfaces.Models;
using Microsoft.EntityFrameworkCore;

namespace BitcoinPriceTracking.BE.DB.Repositories
{
	public class CoindeskRepository<T> : aRepository<T>, ICoindeskRepository where T : MainDatacontext
	{
		public CoindeskRepository(Func<T> contextFactory) : base(contextFactory)
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
				var cryptoDataNote = new CryptoDataNote
				{
					CryptoData = data,
					Note = ""
				};
				var context = _contextFactory();
				await context.CryptoDatas.AddAsync(data);
				await context.CryptoDataNotes.AddAsync(cryptoDataNote);
				await context.SaveChangesAsync();

				return cryptoData;
			}
			catch (Exception ex)
			{
				var test = ex;
				throw;
			}
		}

		public async Task<IEnumerable<CryptoDataNote>> GetCryptoDataNotesAsync()
		{
			try
			{
				var context = _contextFactory();
				var cyptoDataNotes = await context.CryptoDataNotes.Include(x => x.CryptoData).ToListAsync();
				return cyptoDataNotes;
			}
			catch (Exception ex)
			{
				var test = ex;
				throw;
			}
		}
	}
}
