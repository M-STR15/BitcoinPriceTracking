using BitcoinPriceTracking.BE.Shared.Models.DTOs;
using BitcoinPriceTracking.FE.Components.Interfaces;

namespace BitcoinPriceTracking.Models.MVs
{
	public class CryptoDataNoteMV : CryptoDataNoteDTO, IDynamicTableItem
	{
		public bool IsBeingEdited
		{
			get; set;
		}
	}
}