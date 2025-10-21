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
		/// Získá aktuální data o Bitcoinu z bufferu (BTC-EUR).
		/// </summary>
		/// <remarks>
		/// Vrací data z interního bufferu, která nemusí být nejnovějšími daty z databáze.
		/// Pokud nejsou data dostupná, vrací 404 Not Found.
		/// </remarks>
		/// <returns>
		/// 200 OK s <see cref="CryptoDataBaseDTO"/> pokud jsou data dostupná,
		/// 404 Not Found pokud nejsou,
		/// nebo 500 Internal Server Error při výjimce.
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

		/// <summary>
		/// Získá poslední záznam o kryptoměně z databáze.
		/// </summary>
		/// <remarks>
		/// Vrací nejnovější dostupná data o Bitcoinu z databáze. Pokud nejsou data dostupná, vrací 404.
		/// </remarks>
		/// <returns>
		/// 200 OK s <see cref="CryptoDataBaseDTO"/> pokud jsou data dostupná, 404 Not Found pokud nejsou, nebo 500 Internal Server Error při výjimce.
		/// </returns>
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

		/// <summary>
		/// Získá všechny poznámky ke kryptoměnovým datům z databáze.
		/// </summary>
		/// <remarks>
		/// Vrací kolekci poznámek ke kryptoměnovým datům. Pokud nejsou poznámky dostupné, vrací 404 Not Found.
		/// V případě chyby serveru vrací 500 Internal Server Error.
		/// </remarks>
		/// <returns>
		/// 200 OK s kolekcí <see cref="CryptoDataNoteDTO"/> pokud jsou poznámky dostupné,
		/// 404 Not Found pokud nejsou,
		/// nebo 500 Internal Server Error při výjimce.
		/// </returns>
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

		/// <summary>
		/// Přidá nová data o kryptoměně do databáze.
		/// </summary>
		/// <param name="cryptoDataDto">DTO objekt s daty o kryptoměně.</param>
		/// <returns>
		/// 200 OK s <see cref="CryptoDataBaseDTO"/> pokud byla data úspěšně přidána,
		/// 400 Bad Request pokud je vstup neplatný,
		/// nebo 500 Internal Server Error při výjimce.
		/// </returns>
		[HttpPost("api/v1/crypto-data")]
		public async Task<ActionResult<CryptoDataBaseDTO>> AddCryptoDataAsync([FromBody] CryptoDataBaseDTO cryptoDataDto)
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

		#region PUT

		/// <summary>
		/// Uloží upravenou poznámku ke kryptoměnovým datům podle zadaného ID.
		/// </summary>
		/// <param name="cruptoDataNoteId">ID poznámky, která má být upravena.</param>
		/// <param name="cryptoDataNoteDto">DTO objekt s upravenými daty poznámky.</param>
		/// <returns>
		/// 200 OK s <see cref="CryptoDataNoteBaseDTO"/> pokud byla poznámka úspěšně uložena,
		/// 400 Bad Request pokud je vstup neplatný,
		/// nebo 500 Internal Server Error při výjimce.
		/// </returns>
		[HttpPut("api/v1/crypto-data-note/{cruptoDataNoteId}")]
		public async Task<ActionResult<CryptoDataNoteBaseDTO>> SaveCryptoDataNoteAsync(int cruptoDataNoteId, [FromBody] CryptoDataNoteEditDTO cryptoDataNoteDto)
		{
			try
			{
				var cryptodataOrig = await _coindeskRepositories.GetCryptoDataNoteAsync(cruptoDataNoteId);
				cryptodataOrig.Note = cryptoDataNoteDto.Note;

				if (cryptodataOrig != null)
				{
					var result = await _coindeskRepositories.UpdateCryptoDataNoteAsync(cryptodataOrig);
					if (result != null && _mapper != null)
					{
						cryptoDataNoteDto = _mapper.Map<CryptoDataNoteBaseDTO>(result);
						return result != null ? Ok(cryptoDataNoteDto) : Problem();
					}
					else
					{
						return Problem();
					}
				}
				else
				{
					return BadRequest();
				}
			}
			catch (Exception ex)
			{
				_eventLogService.LogError(Guid.Parse("604ecf36-2086-4608-a468-52894ab4ae55"), ex);
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

		#endregion PUT

		#region DELETE

		/// <summary>
		/// Smaže záznam o kryptoměně podle zadaného ID.
		/// </summary>
		/// <param name="cryptoDataId">ID záznamu kryptoměny, který má být smazán.</param>
		/// <returns>
		/// 200 OK pokud byl záznam úspěšně smazán,
		/// nebo 500 Internal Server Error při chybě.
		/// </returns>
		[HttpDelete("api/v1/crypto-data/{cryptoDataId}")]
		public async Task<IActionResult> DeleteCryptoDataAsync(int cryptoDataId)
		{
			try
			{
				var result = await _coindeskRepositories.DeleteCryptoDataAsync(cryptoDataId);
				return result ? Ok() : Problem();
			}
			catch (Exception ex)
			{
				_eventLogService.LogError(Guid.Parse("00bc4790-5d99-440b-9681-631c850d54aa"), ex);
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

		#endregion DELETE
	}
}