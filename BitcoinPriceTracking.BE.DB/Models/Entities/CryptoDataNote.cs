using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BitcoinPriceTracking.BE.DB.Models.Entities
{
	[Table("Crypto_data_notes", Schema = "dbo")]
	public class CryptoDataNote
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Note { get; set; } = string.Empty;

		public DateTime TimeStamp { get; set; }

		public int CryptoDataId { get; set; }
		[ForeignKey("CryptoDataId")]
		public virtual CryptoData CryptoData { get; set; } = null!;
		public CryptoDataNote()
		{
			TimeStamp = DateTime.UtcNow;
		}
	}
}
