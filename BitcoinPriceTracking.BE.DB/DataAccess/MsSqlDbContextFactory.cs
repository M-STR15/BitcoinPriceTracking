using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BitcoinPriceTracking.BE.DB.DataAccess
{
	public class MsSqlDbContextFactory : IDesignTimeDbContextFactory<MsSqlDbContext>
	{
		public MsSqlDbContext CreateDbContext(string[] args)
		{
			var basePath = Path.Combine(Directory.GetCurrentDirectory(), "..", "BitcoinPriceTracking");

			var configuration = new ConfigurationBuilder()
				.SetBasePath(basePath)
				.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
				.Build();

			// správný název connection stringu
			var connectionString = configuration.GetConnectionString("ConnectionStringsMSSQL");

			// fallback, pokud configuration selže
			if (string.IsNullOrEmpty(connectionString))
			{
				connectionString = @"Server=.;Database=BitcoinPriceTracking;Trusted_Connection=True;TrustServerCertificate=True;";
			}

			var optionsBuilder = new DbContextOptionsBuilder<MsSqlDbContext>();
			optionsBuilder.UseSqlServer(connectionString);

			return new MsSqlDbContext(optionsBuilder.Options);
		}
	}
}