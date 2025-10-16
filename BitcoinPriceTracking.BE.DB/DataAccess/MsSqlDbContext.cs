using BitcoinPriceTracking.BE.DB.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BitcoinPriceTracking.BE.DB.DataAccess
{
	public class MsSqlDbContext : MainDatacontext
	{
		public MsSqlDbContext(DbContextOptions<MsSqlDbContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			_modelBuilder = modelBuilder;
			//modelBuilder.Entity<CryptoData>().HasNoKey();

			base.OnModelCreating(modelBuilder);

			// insertDefaultValues_Activities();
			// insertDefaultValues_TypeShifts();
			// setSubModuleTable();
		}
	}
}
