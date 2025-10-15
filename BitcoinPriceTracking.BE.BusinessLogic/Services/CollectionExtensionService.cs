using BitcoinPriceTracking.BE.BusinessLogic.Stories;
using Microsoft.Extensions.DependencyInjection;

namespace BitcoinPriceTracking.BE.BusinessLogic.Services
{
	public static class CollectionExtensionService
	{
		public static IServiceCollection AddBitcoinPriceTrackingBeBusinessLogicServices(this IServiceCollection services)
		{
			services.AddSingleton<CryptoDataStory>();

			services.AddHostedService<TimedHostedService>();
			return services;
		}
	}
}
