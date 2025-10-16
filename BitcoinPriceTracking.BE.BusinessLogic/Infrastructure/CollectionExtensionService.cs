using BitcoinPriceTracking.BE.BusinessLogic.MappingProfiles;
using BitcoinPriceTracking.BE.BusinessLogic.Services;
using BitcoinPriceTracking.BE.BusinessLogic.Stories;
using BitcoinPriceTracking.BE.DB.DataAccess;
using BitcoinPriceTracking.BE.DB.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace BitcoinPriceTracking.BE.BusinessLogic.Infrastructure
{
	public static class CollectionExtensionService
	{
		public static IServiceCollection AddBitcoinPriceTrackingBeBusinessLogicServices<TContext>(this IServiceCollection services) where TContext : MainDatacontext
		{
			services.AddBitcoinPriceTrackingBeDbServices<TContext>();

			services.AddAutoMapper(cfg => { }, typeof(MappingProfile));

			services.AddSingleton<CnbStory>();
			services.AddSingleton<CryptoDataStory>();

			services.AddHostedService<CoindeskTimedHostedService>();
			services.AddHostedService<CNBTimedHostedService>();

			//services.AddControllers();

			return services;
		}
	}
}
