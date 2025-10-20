using System.ComponentModel.DataAnnotations;

namespace BitcoinPriceTracking.BE.Shared.Models.DTOs
{
	public class CryptoDataNoteEditDTO
	{
		[Required]
		[MaxLength(50)]
		[Editable(true)]
		public virtual string Note { get; set; } = string.Empty;
	}
}
