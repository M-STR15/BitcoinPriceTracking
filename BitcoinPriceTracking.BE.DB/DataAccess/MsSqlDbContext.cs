using Microsoft.EntityFrameworkCore;

namespace BitcoinPriceTracking.BE.DB.DataAccess
{
	public class MsSqlDbContext : MainDatacontext
	{
		public MsSqlDbContext(DbContextOptions<MsSqlDbContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			_modelBuilder = modelBuilder;

			base.OnModelCreating(modelBuilder);
		}
	}
}
