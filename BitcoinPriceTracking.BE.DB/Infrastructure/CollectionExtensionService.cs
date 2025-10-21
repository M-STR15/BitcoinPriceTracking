using BitcoinPriceTracking.BE.DB.DataAccess;
using BitcoinPriceTracking.BE.DB.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BitcoinPriceTracking.BE.DB.Infrastructure
{
	public static class CollectionExtensionService
	{
		public static IServiceCollection AddBitcoinPriceTrackingBeDbServices<TContext>(this IServiceCollection services)
		where TContext : MainDatacontext
		{
			var basePath = Path.Combine(Directory.GetCurrentDirectory(), "..", "BitcoinPriceTracking");

			var configuration = new ConfigurationBuilder()
				.SetBasePath(basePath)
				.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
				.Build();

			var connectionString = configuration.GetConnectionString("DefaultConnection")
								   ?? @"Server=DESKTOP-JS0N1LD\SQLEXPRESS;Database=BitcoinPriceTracking;Trusted_Connection=True;TrustServerCertificate=True;";

			// DbContext podle generického typu
			services.AddDbContext<TContext>(options =>
			{
				options.UseSqlServer(connectionString);
			});

			services.AddScoped<Func<TContext>>(provider => () => provider.GetRequiredService<TContext>());
			services.AddScoped<ICoindeskRepository, CoindeskRepository<TContext>>();

			// Automatické vytvoření databáze
			using (var serviceProvider = services.BuildServiceProvider())
			using (var scope = serviceProvider.CreateScope())
			{
				var dbContext = scope.ServiceProvider.GetRequiredService<TContext>();
				try
				{
					dbContext.Database.Migrate();
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Chyba při migraci databáze: {ex.Message}");
				}
			}

			return services;
		}
	}
}