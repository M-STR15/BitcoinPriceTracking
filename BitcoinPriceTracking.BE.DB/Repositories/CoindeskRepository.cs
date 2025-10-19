using BitcoinPriceTracking.BE.DB.DataAccess;
using BitcoinPriceTracking.BE.DB.Models.Entities;
using BitcoinPriceTracking.BE.Shared.Interfaces.Models;
using Microsoft.EntityFrameworkCore;
using System;

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

				return data;
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

		public async Task<CryptoDataNote?> UpdateCryptoDataNoteAsync(ICryptoData cryptoDataNote)
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
				var test = ex;
				throw;
			}
		}

		public async Task<bool> DeleteCryptoDataNoteAsync(int cryptoDataNoteId)
		{
			try
			{
				var context = _contextFactory();
				var removedData = context.CryptoDataNotes.Find(cryptoDataNoteId);
				if (removedData != null)
				{
					context.CryptoDataNotes.Remove(removedData);
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
				var test = ex;
				throw;
			}
		}
	}
}
