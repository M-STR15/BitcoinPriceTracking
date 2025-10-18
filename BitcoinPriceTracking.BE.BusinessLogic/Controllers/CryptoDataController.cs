using AutoMapper;
using BitcoinPriceTracking.BE.BusinessLogic.Stories;
using BitcoinPriceTracking.BE.DB.Models.Entities;
using BitcoinPriceTracking.BE.DB.Repositories;
using BitcoinPriceTracking.BE.Shared.Models.DTOs;
using BitcoinPriceTracking.BE.Shared.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BitcoinPriceTracking.BE.BusinessLogic.Controllers
{
	[ApiExplorerSettings(GroupName = "v1")]
	public class CryptoDataController : aControllerBase
	{
		private readonly CryptoDataStory _cryptoDataStory;
		private readonly ICoindeskRepository _coindeskRepositories;
		public CryptoDataController(IMapper mapper, IEventLogService eventLogService, CnbStory cnbStory, CryptoDataStory cryptoDataStory, ICoindeskRepository coindeskRepositories) : base(mapper, eventLogService)
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
		/// 200 OK s <see cref="CryptoDataBaseDto"/> pokud jsou data dostupná, 404 Not Found pokud nejsou, nebo 500 Internal Server Error při výjimce.
		/// </returns>
		[HttpGet("api/v1/crypto-data/buffer/BTC-EUC")]
		public async Task<ActionResult<CryptoDataBaseDTO>> GetCryptoDataFromBufferAsync()
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

		[HttpGet("api/v1/crypto-data/last-record")]
		public async Task<ActionResult<CryptoDataBaseDTO>> GetCryptoDataFromDatabaseAsync()
		{
			try
			{
				var cryptoData = await _coindeskRepositories.GetLastCryptoDataAsync();
				var cryptoDataDto = _mapper.Map<CryptoDataBaseDTO>(cryptoData);
				if (cryptoDataDto != null)
					return cryptoDataDto != null ? Ok(cryptoDataDto) : BadRequest();
				else
					return NotFound();
			}
			catch (Exception ex)
			{
				_eventLogService.LogError(Guid.Parse("92344ec4-e18f-4cef-ab10-631c18775e67"), ex);
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

		[HttpGet("api/v1/crypto-data-note")]
		public async Task<ActionResult<IEnumerable<CryptoDataNoteDTO>>> GetCryptoDataNoteFromDatabaseAsync()
		{
			try
			{
				var cryptoDataNote = await _coindeskRepositories.GetCryptoDataNotesAsync();
				var cryptoDataNoteDto = _mapper.Map<IEnumerable<CryptoDataNoteDTO>>(cryptoDataNote);	
				if (cryptoDataNoteDto != null)
					return cryptoDataNoteDto != null ? Ok(cryptoDataNoteDto) : BadRequest();
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

		[HttpPost("api/v1/crypto-data")]
		public async Task<ActionResult<CryptoDataBaseDTO>> AddSubModulesAsync([FromBody] CryptoDataBaseDTO cryptoDataDto)
		{
			try
			{
				var cryptoData = _mapper.Map<CryptoData>(cryptoDataDto);
				if (cryptoData != null)
				{
					var result = await _coindeskRepositories.AddCryptoDataAsync(cryptoData);
					cryptoDataDto = _mapper.Map<CryptoDataBaseDTO>(result);
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
