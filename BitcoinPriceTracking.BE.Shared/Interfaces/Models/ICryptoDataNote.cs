
namespace BitcoinPriceTracking.BE.DB.Models.Entities
{
	public interface ICryptoDataNoteBase
	{
		int CryptoDataId { get; set; }
		int Id { get; set; }
		string Note { get; set; }
		DateTime TimeStamp { get; set; }
	}
}