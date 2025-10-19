using BitcoinPriceTracking.FE.Components.Interops;
using BitcoinPriceTracking.FE.Components.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BitcoinPriceTracking.FE.Components.Infrastructure
{
	public static class CollectionExtensionService
	{
		public static IServiceCollection AddBitcoinPriceTrackingFEComponents(this IServiceCollection services)
		{
			services.AddScoped<ChartJsInterop>();
			services.AddScoped<ToastNotificationService>();

			return services;
		}
	}
}
