using Microsoft.Extensions.DependencyInjection;

namespace BitcoinPriceTracking.BE.Shared.Services
{
	public static class CollectionExtensionService
	{
		public static IServiceCollection AddBitcoinPriceTrackingBeSharedServices(this IServiceCollection services)
		{
			services.AddSingleton<IEventLogService, EventLogService>();
			return services;
		}
	}
}
