using AutoMapper;
using BitcoinPriceTracking.BE.BusinessLogic.Stories;
using BitcoinPriceTracking.BE.DB.DataAccess;
using BitcoinPriceTracking.BE.DB.Models.Entities;
using BitcoinPriceTracking.BE.DB.Repositories;
using BitcoinPriceTracking.BE.Shared.Services;
using BitcoinPriceTracking.BE.Shared.Shared.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BitcoinPriceTracking.BE.BusinessLogic.Controllers
{
	[ApiExplorerSettings(GroupName = "v1")]
	public class CryptoDataController : aControllerBase
	{
		private readonly CryptoDataStory _cryptoDataStory;
		private readonly CoindeskRepositories<MsSqlDbContext> _coindeskRepositories;
		public CryptoDataController(IMapper mapper, IEventLogService eventLogService, CnbStory cnbStory, CryptoDataStory cryptoDataStory, CoindeskRepositories<MsSqlDbContext> coindeskRepositories) : base(mapper, eventLogService)
		{
			_cryptoDataStory = cryptoDataStory;
			_coindeskRepositories = coindeskRepositories;
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
		[HttpGet("api/v1/crypto-data/buffer/BTC-EUC")]
		public async Task<ActionResult<CryptoDataDto>> GetCryptoDataFromBufferAsync()
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

		[HttpGet("api/v1/crypto-data/database/last-record")]
		public async Task<ActionResult<CryptoDataDto>> GetCryptoDataFromDatabaseAsync()
		{
			try
			{
				var cryptoData = await _coindeskRepositories.GetLastCryptoDataAsync();

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

		#region POST

		[HttpPost("api/v1/crypto-data/database")]
		public async Task<ActionResult<CryptoDataDto>> AddSubModulesAsync([FromBody] CryptoDataDto cryptoDataDto)
		{
			try
			{
				var cryptoData = _mapper.Map<CryptoData>(cryptoDataDto);
				if (cryptoData != null)
				{
					var result = await _coindeskRepositories.AddCryptoDataAsync(cryptoData);
					cryptoDataDto = _mapper.Map<CryptoDataDto>(result);
					return result != null ? Ok(cryptoDataDto) : Problem();
				}
				else
				{
					return BadRequest();
				}
			}
			catch (Exception ex)
			{
				_eventLogService.LogError(Guid.Parse("71c4af17-9b5c-4ccc-a474-d5efcd8fb188"), ex);
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}
		#endregion POST
	}
}
