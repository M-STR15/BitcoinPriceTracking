using BitcoinPriceTracking.BE.DB.DataAccess;

namespace BitcoinPriceTracking.BE.DB.Repositories
{
	public class CnbRepository<T> : aRepository<T> where T : MainDatacontext
	{
		public CnbRepository(Func<T> contextFactory) : base(contextFactory)
		{

		}
	}
}
