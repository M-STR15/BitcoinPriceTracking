using AutoMapper;
using BitcoinPriceTracking.BE.BusinessLogic.Stories;
using BitcoinPriceTracking.BE.DB.DataAccess;
using BitcoinPriceTracking.BE.DB.Repositories;
using BitcoinPriceTracking.BE.Shared.Services;
using BitcoinPriceTracking.BE.Shared.Shared.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BitcoinPriceTracking.BE.BusinessLogic.Controllers
{
	[ApiExplorerSettings(GroupName = "v1")]
	public class CnbController : aControllerBase
	{
		private readonly CnbStory _cnbStory;
		public CnbController(IMapper mapper, IEventLogService eventLogService, CnbStory cnbStory) : base(mapper, eventLogService)
		{
			_cnbStory = cnbStory;
		}

		[HttpGet("api/v1/cnb-data/buffer")]
		public async Task<ActionResult<CryptoDataDto>> GetCnbDataFromBufferAsync()
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
	}
}
