using BitcoinPriceTracking.BE.DB.Models.Entities;
using BitcoinPriceTracking.BE.Shared.Interfaces.Models;
using System.Threading.Tasks;

namespace BitcoinPriceTracking.BE.DB.Repositories
{
	public interface ICoindeskRepository
	{
		Task<ICryptoData> AddCryptoDataAsync(ICryptoData cryptoData);
		Task<ICryptoData> GetLastCryptoDataAsync();
		Task<IEnumerable<CryptoDataNote>> GetCryptoDataNotesAsync();
		Task<CryptoDataNote> GetCryptoDataNoteAsync(int cryptoDataNoteId);
		Task<CryptoDataNote> UpdateCryptoDataNoteAsync(CryptoDataNote cryptoDataNote);
		Task<bool> DeleteCryptoDataAsync(int cryptoDataNoteId);
	}
}