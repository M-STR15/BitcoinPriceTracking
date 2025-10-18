using BitcoinPriceTracking.BE.BusinessLogic.Models;
using BitcoinPriceTracking.BE.BusinessLogic.Stories;
using BitcoinPriceTracking.BE.Shared.Interfaces.Models;
using BitcoinPriceTracking.BE.Shared.Services;
using Microsoft.Extensions.Hosting;
using System.Xml.Serialization;

namespace BitcoinPriceTracking.BE.BusinessLogic.Services
{
	public class CNBTimedHostedService : IHostedService, IDisposable
	{
		private readonly IEventLogService _eventLogService;
		private readonly HttpClient _httpCnbClient;
		private readonly CnbStory _cnbStory;
		private Timer? _refreshBufferTimer;

		public CNBTimedHostedService(IHttpClientFactory httpClientFactory, IEventLogService eventLogService, CnbStory cnbStory)
		{
			_httpCnbClient = httpClientFactory.CreateClient("ApiCNBClient");
			_eventLogService = eventLogService;
			_cnbStory = cnbStory;
		}

		public void Dispose()
		{
			_refreshBufferTimer?.Dispose();
		}

		public Task StartAsync(CancellationToken cancellationToken)
		{
			_refreshBufferTimer = new Timer(doWork, null, TimeSpan.FromSeconds(2), TimeSpan.FromDays(1));
			var message = "Nastartování timeru ĆNB pro ukládání hodnot do bufferu.";
			_eventLogService.LogInformation(Guid.Parse("b3fe01f6-6cec-4b0d-90ab-20aa80ef8839"), null, message);
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
				_eventLogService.LogError(Guid.Parse("26753ddf-a2e8-47c6-b6e4-910cff3e688d"), ex);
			}
		}

		private async Task refreshBufferData()
		{
			try
			{
				if (_httpCnbClient != null)
				{
					var result = await _httpCnbClient.GetAsync("/cs/financni-trhy/devizovy-trh/kurzy-devizoveho-trhu/kurzy-devizoveho-trhu/denni_kurz.xml");

					if (result.IsSuccessStatusCode)
					{
						var raw = await result.Content.ReadAsStringAsync();
						var serializer = new XmlSerializer(typeof(kurzy));
						using var reader = new StringReader(raw);
						var data = (kurzy)serializer.Deserialize(reader);

						_cnbStory.DailyRate = data;
					}
				}
			}
			catch (Exception ex)
			{
				_eventLogService.LogError(Guid.Parse("6d87e826-5a2e-43fe-8c36-faca6f9ffef6"), ex);
			}
		}
	}
}