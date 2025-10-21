using System.ComponentModel.DataAnnotations;

namespace BitcoinPriceTracking.BE.Shared.Models.DTOs
{
	public class CryptoDataNoteEditDTO
	{
		[Required(ErrorMessage = "Poznámka je povinná")	]
		[MaxLength(50,ErrorMessage ="Maximální dovolený počet znaků: 50")]
		[Editable(true)]
		public virtual string Note { get; set; } = string.Empty;
	}
}