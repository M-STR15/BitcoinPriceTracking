using BitcoinPriceTracking.BE.DB.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BitcoinPriceTracking.BE.DB.DataAccess
{
	public class MsSqlDbContext : MainDatacontext
	{
		public MsSqlDbContext(DbContextOptions<MsSqlDbContext> options) : base(options) { }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(@"Server=DESKTOP-JS0N1LD\SQLEXPRESS;Integrated Security=true;TrustServerCertificate=true;Database=BitcoinPriceTracking");
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			_modelBuilder = modelBuilder;
			modelBuilder.Entity<CryptoData>().HasNoKey();
			base.OnModelCreating(modelBuilder);

			//insertDefaultValues_Activities();
			//insertDefaultValues_TypeShifts();

			//setSubModuleTable();
		}
	}
}
