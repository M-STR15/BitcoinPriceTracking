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
				return await context?.CryptoDatas?.LastOrDefaultAsync();
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

				return data;
			}
			catch (Exception ex)
			{
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
				throw;
			}
		}

		public async Task<CryptoDataNote> GetCryptoDataNoteAsync(int cryptoDataNoteId)
		{
			try
			{
				var context = _contextFactory();
				var cyptoDataNote = await context.CryptoDataNotes.Include(x => x.CryptoData).FirstOrDefaultAsync(x => x.Id == cryptoDataNoteId);
				return cyptoDataNote;
			}
			catch (Exception ex)
			{
				throw;
			}
		}

		public async Task<CryptoDataNote?> UpdateCryptoDataNoteAsync(CryptoDataNote cryptoDataNote)
		{
			try
			{
				var data = (CryptoDataNote)cryptoDataNote;
				var context = _contextFactory();
				context.CryptoDataNotes.Update(data);
				await context.SaveChangesAsync();

				return data;
			}
			catch (Exception ex)
			{
				throw;
			}
		}

		public async Task<bool> DeleteCryptoDataAsync(int cryptoDataId)
		{
			try
			{
				var context = _contextFactory();
				var removedCryptoData = context.CryptoDatas.Find(cryptoDataId);
				var removedCryptoDataId = removedCryptoData?.Id;
				var removedCryptoDataNote = context.CryptoDataNotes.FirstOrDefault(x => x.CryptoDataId == removedCryptoDataId);

				if (removedCryptoDataNote != null && removedCryptoData != null)
				{
					context.CryptoDataNotes.Remove(removedCryptoDataNote);
					context.CryptoDatas.Remove(removedCryptoData);
					await context.SaveChangesAsync();

					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				throw;
			}
		}
	}
}