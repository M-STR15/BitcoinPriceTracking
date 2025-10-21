namespace BitcoinPriceTracking.BE.DB.Models.Entities
{
	public abstract class aBaseEntityData
	{
		/// <summary>
		/// Ćasové razítko vytvoření záznamu.
		/// </summary>
		/// <remarks>
		/// Ukládáno v UTC formátu.
		/// </remarks>	>
		public DateTime TimeStamp { get; set; }

		public aBaseEntityData()
		{
			TimeStamp = DateTime.UtcNow;
		}
	}
}