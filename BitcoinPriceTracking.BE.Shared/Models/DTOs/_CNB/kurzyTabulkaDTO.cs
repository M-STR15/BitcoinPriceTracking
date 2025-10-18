
namespace BitcoinPriceTracking.BE.Shared.Interfaces.Models
{
	public partial class kurzyTabulkaDTO : IkurzyTabulka
	{

		private kurzyTabulkaRadek[] radekField;

		private string typField;

		public kurzyTabulkaRadek[] radek
		{
			get
			{
				return this.radekField;
			}
			set
			{
				this.radekField = value;
			}
		}

		public string typ
		{
			get
			{
				return this.typField;
			}
			set
			{
				this.typField = value;
			}
		}
	}

}
