using BitcoinPriceTracking.BE.DB.DataAccess;

namespace BitcoinPriceTracking.BE.DB.Repositories
{
	public abstract class aRepository<T> where T : MainDatacontext
	{
		protected readonly Func<T> _contextFactory;

		public aRepository(Func<T> contextFactory)
		{
			_contextFactory = contextFactory;
		}
	}
}