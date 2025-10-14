using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinPriceTracking.BE.Shared.Services
{
	public class TimedHostedService : IHostedService, IDisposable
	{
		private readonly IEventLogService _eventLogService;
		private readonly HttpClient _httpClient;
		private Timer? _refreshBufferTimer;
	
		public TimedHostedService(IHttpClientFactory httpClientFactory, IEventLogService eventLogService)
		{
			_httpClient = httpClientFactory.CreateClient("ApiClient");
			_eventLogService = eventLogService;
		}

		public void Dispose()
		{
			_refreshBufferTimer?.Dispose();
		}

		public Task StartAsync(CancellationToken cancellationToken)
		{
			_refreshBufferTimer = new Timer(doWork, null, TimeSpan.FromSeconds(2), TimeSpan.FromSeconds(20));
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
				if (_httpClient != null)
				{
					var result = await _httpClient.GetAsync("/api/v1/reports/total-order-by-product");

					if (result.IsSuccessStatusCode)
					{
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