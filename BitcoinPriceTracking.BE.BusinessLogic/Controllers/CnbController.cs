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
	public class CnbController : aControllerBase
	{
		private readonly CnbStory _cnbStory;
		private readonly ICoindeskRepository _coindeskRepository;
		public CnbController(IMapper mapper, IEventLogService eventLogService, CnbStory cnbStory, ICoindeskRepository coindeskRepository) : base(mapper, eventLogService)
		{
			_cnbStory = cnbStory;
			_coindeskRepository = coindeskRepository;
		}

		[HttpGet("api/v1/cnb-data/buffer")]
		public async Task<ActionResult<CryptoDataBaseDTO>> GetCnbDataFromBufferAsync()
		{
			try
			{
				var cnbData = _cnbStory.DailyRate;
				if (cnbData != null)
					return cnbData != null ? Ok(cnbData) : BadRequest();
				else
					return NotFound();
			}
			catch (Exception ex)
			{
				_eventLogService.LogError(Guid.Parse("3c46ac36-052b-4461-b0b3-36f6c1c6acd3"), ex);
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

		//[HttpGet("api/v1/cnb-data")]
		//public async Task<ActionResult<IEnumerable<CryptoDataNoteDTO>>> GetCnbDataFromDatabaseAsync()
		//{
		//	try
		//	{
		//		var cryptoDataNotes = _coindeskRepository.GetCryptoDataNotesAsync();
		//		if (cryptoDataNotes != null)
		//			return cryptoDataNotes != null ? Ok(cryptoDataNotes) : BadRequest();
		//		else
		//			return NotFound();
		//	}
		//	catch (Exception ex)
		//	{
		//		_eventLogService.LogError(Guid.Parse("855d8115-aafc-40ed-b542-2e866a139a67"), ex);
		//		return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
		//	}
		//}
	}
}
