using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BitcoinPriceTracking.BE.DB.DataAccess
{
	public class MsSqlDbContextFactory : IDesignTimeDbContextFactory<MsSqlDbContext>
	{
		public MsSqlDbContext CreateDbContext(string[] args)
		{
			// Získá aktuální adresář (bude to složka projektu .BE.DB)
			var basePath = Path.Combine(Directory.GetCurrentDirectory(), "..", "BitcoinPriceTracking");

			// Pokud se appsettings.json nachází ve startup projektu,
			// můžeš přidat o úroveň výš:
			// var basePath = Path.Combine(Directory.GetCurrentDirectory(), "..", "BitcoinPriceTracking");

			var configuration = new ConfigurationBuilder()
				.SetBasePath(basePath)
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
				.Build();

			var connectionString = configuration.GetConnectionString("ConnectionStrings")
				?? "Server=DESKTOP-JS0N1LD\\SQLEXPRESS;Integrated Security=true;TrustServerCertificate=true;Database=BitcoinPriceTracking";

			var optionsBuilder = new DbContextOptionsBuilder<MsSqlDbContext>();
			optionsBuilder.UseSqlServer(connectionString);

			return new MsSqlDbContext(optionsBuilder.Options);
		}
	}
}
