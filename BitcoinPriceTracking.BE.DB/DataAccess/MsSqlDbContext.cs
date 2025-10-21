using BitcoinPriceTracking.BE.DB.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BitcoinPriceTracking.BE.DB.DataAccess
{
	public class MsSqlDbContext : MainDatacontext
	{
		public MsSqlDbContext(DbContextOptions<MsSqlDbContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			_modelBuilder = modelBuilder;

			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<CryptoData>()
						  .HasOne(d => d.CryptoDataNote)
						  .WithOne(n => n.CryptoData)
						  .HasForeignKey<CryptoDataNote>(n => n.CryptoDataId)
						  .OnDelete(DeleteBehavior.Restrict);
		}
	}
}