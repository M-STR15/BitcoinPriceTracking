using BitcoinPriceTracking.BE.DB.DataAccess;
using BitcoinPriceTracking.BE.DB.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinPriceTracking.BE.DB.Infrastructure
{
	public static class CollectionExtensionService
	{
		private const string _connectionString = @"Server=DESKTOP-JS0N1LD\SQLEXPRESS;Integrated Security=true;TrustServerCertificate=true;Database=TimeTrackerDB";

		public static IServiceCollection AddBitcoinPriceTrackingBeDbServices<TContext>(this IServiceCollection services) where TContext : MainDatacontext
		{
			services.AddScoped<Func<TContext>>(sp =>
			{
				var provider = sp;
				return () => provider.GetRequiredService<TContext>();
			});

			services.AddScoped<ICoindeskRepositories, CoindeskRepositories<TContext>>();

			return services;
		}
	}
}
