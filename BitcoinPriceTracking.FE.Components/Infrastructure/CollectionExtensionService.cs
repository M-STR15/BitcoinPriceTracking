using BitcoinPriceTracking.FE.Components.Interops;
using Microsoft.Extensions.DependencyInjection;

namespace BitcoinPriceTracking.FE.Components.Infrastructure
{
	public static class CollectionExtensionService
	{
		public static IServiceCollection AddBitcoinPriceTrackingFEComponents(this IServiceCollection services)
		{
			services.AddScoped<ChartJsInterop>();

			return services;
		}
	}
}
