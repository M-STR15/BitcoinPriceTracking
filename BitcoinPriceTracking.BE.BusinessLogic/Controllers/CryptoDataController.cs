using AutoMapper;
using BitcoinPriceTracking.BE.BusinessLogic.Models.DTOs;
using BitcoinPriceTracking.BE.BusinessLogic.Stories;
using BitcoinPriceTracking.BE.Shared.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BitcoinPriceTracking.BE.BusinessLogic.Controllers
{
	[ApiExplorerSettings(GroupName = "v1")]
	public class CryptoDataController : aControllerBase
	{
		private readonly CnbStory _cnbStory;
		private readonly CryptoDataStory _cryptoDataStory;
		public CryptoDataController( IEventLogService eventLogService, CnbStory cnbStory, CryptoDataStory cryptoDataStory) : base( eventLogService)
		{
			_cnbStory = cnbStory;
			_cryptoDataStory = cryptoDataStory;
		}

		#region GET
		/// <summary>
		/// Získá aktuální data o kryptoměně BTC vůči EUR.
		/// </summary>
		/// <remarks>
		/// Vrací nejnovější dostupná data o Bitcoinu vůči euru. Pokud nejsou data dostupná, vrací 404.
		/// </remarks>
		/// <returns>
		/// 200 OK s <see cref="CryptoDataDto"/> pokud jsou data dostupná, 404 Not Found pokud nejsou, nebo 500 Internal Server Error při výjimce.
		/// </returns>
		[HttpGet("api/v1/crypto-data/BTC-EUC")]
		public async Task<ActionResult<CryptoDataDto>> GetActivitiesAsync()
		{
			try
			{
				var cryptoData = _cryptoDataStory.CryptoDataBTC_EUR;
				if (cryptoData != null)
					return cryptoData != null ? Ok(cryptoData) : BadRequest();
				else
					return NotFound();
			}
			catch (Exception ex)
			{
				_eventLogService.LogError(Guid.Parse("92344ec4-e18f-4cef-ab10-631c18775e67"), ex);
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

		#endregion GET
	}
}
