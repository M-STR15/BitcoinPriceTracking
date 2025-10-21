using BitcoinPriceTracking.BE.DB.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BitcoinPriceTracking.BE.DB.DataAccess
{
	public abstract class MainDatacontext : DbContext
	{
		protected ModelBuilder _modelBuilder { get; set; }
		public DbSet<CryptoData> CryptoDatas { get; set; }
		public DbSet<CryptoDataNote> CryptoDataNotes { get; set; }
		public string DbPath { get; set; } = string.Empty;

		public MainDatacontext(DbContextOptions options) : base(options)
		{
		}
	}
}