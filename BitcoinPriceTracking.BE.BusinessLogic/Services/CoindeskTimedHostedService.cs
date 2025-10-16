using BitcoinPriceTracking.BE.BusinessLogic.Models;
using BitcoinPriceTracking.BE.BusinessLogic.Stories;
using BitcoinPriceTracking.BE.Shared.Services;
using Microsoft.Extensions.Hosting;
using System.Net.Http.Json;

namespace BitcoinPriceTracking.BE.BusinessLogic.Services
{
	public class CoindeskTimedHostedService : IHostedService, IDisposable
	{
		private readonly IEventLogService _eventLogService;
		private readonly HttpClient _httpCoindeskClient;
		private readonly CryptoDataStory _cryptoDataStory;
		private Timer? _refreshBufferTimer;

		public CoindeskTimedHostedService(IHttpClientFactory httpClientFactory, IEventLogService eventLogService, CryptoDataStory cryptoDataStory)
		{
			_httpCoindeskClient = httpClientFactory.CreateClient("ApiCoindeskClient");
			_eventLogService = eventLogService;
			_cryptoDataStory = cryptoDataStory;
		}

		public void Dispose()
		{
			_refreshBufferTimer?.Dispose();
		}

		public Task StartAsync(CancellationToken cancellationToken)
		{
			_refreshBufferTimer = new Timer(doWork, null, TimeSpan.FromSeconds(2), TimeSpan.FromSeconds(60));
			var message = "Nastartování timeru pro ukládání hodnot do bufferu.";
			_eventLogService.LogInformation(Guid.Parse("1f7650c4-65a8-4738-b8a2-13e5140f5cc1"), null, message);
			return Task.CompletedTask;
		}

		public Task StopAsync(CancellationToken cancellationToken)
		{
			_ = (_refreshBufferTimer?.Change(Timeout.Infinite, 0));
			return Task.CompletedTask;
		}

		private async void doWork(object state)
		{
			try
			{
				await refreshBufferData();
			}
			catch (Exception ex)
			{
				_eventLogService.LogError(Guid.Parse("37fdf305-03b4-46dd-961e-2af6e7c9b013"), ex);
			}
		}

		private async Task refreshBufferData()
		{
			try
			{
				if (_httpCoindeskClient != null)
				{
					var result = await _httpCoindeskClient.GetAsync("/spot/v1/latest/tick?market=coinbase&instruments=BTC-EUR");

					if (result.IsSuccessStatusCode)
					{
						var resultData = await result.Content.ReadFromJsonAsync<RootobjectDto>();
						_cryptoDataStory.CryptoDataBTC_EUR = resultData.Data.FirstOrDefault(x => x.Key == "BTC-EUR").Value;
						//var raw = await result.Content.ReadAsStringAsync();
						//var test=JsonConvert.DeserializeObject<Rootobject>(raw);
					}
				}
			}
			catch (Exception ex)
			{
				_eventLogService.LogError(Guid.Parse("38eeba7d-e0f4-4fc2-a698-07db6b2f0569"), ex);
			}
		}
	}
}