using BitcoinPriceTracking.BE.BusinessLogic.Stories;
using Microsoft.Extensions.DependencyInjection;

namespace BitcoinPriceTracking.BE.BusinessLogic.Services
{
	public static class CollectionExtensionService
	{
		public static IServiceCollection AddBitcoinPriceTrackingBeBusinessLogicServices(this IServiceCollection services)
		{
			services.AddSingleton<CnbStory>();
			services.AddSingleton<CryptoDataStory>();

			services.AddHostedService<CoindeskTimedHostedService>();
			services.AddHostedService<CNBTimedHostedService>();

			//services.AddControllers();
			return services;
		}
	}
}
