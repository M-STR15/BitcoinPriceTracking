using AutoMapper;
using BitcoinPriceTracking.BE.BusinessLogic.Stories;
using BitcoinPriceTracking.BE.DB.DataAccess;
using BitcoinPriceTracking.BE.DB.Repositories;
using BitcoinPriceTracking.BE.Shared.Services;
using BitcoinPriceTracking.BE.Shared.Shared.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinPriceTracking.BE.BusinessLogic.Controllers
{
	[ApiExplorerSettings(GroupName = "v1")]
	public class CnbController : aControllerBase
	{
		private readonly CnbStory _cnbStory;
		private readonly CoindeskRepositories<MsSqlDbContext> _coindeskRepositories;
		public CnbController(IMapper mapper, IEventLogService eventLogService, CnbStory cnbStory) : base(mapper, eventLogService)
		{
			_cnbStory = cnbStory;
		}

		[HttpGet("api/v1/cnb-data/buffer")]
		public async Task<ActionResult<CryptoDataDto>> GetCnbDataFromBufferAsync()
		{
			try
			{
				var cryptoData = _cnbStory.DailyRate;
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
	}
}
