namespace BitcoinPriceTracking.BE.Shared.Interfaces.Models
{
	public partial class kurzyDTO : Ikurzy
	{
		private kurzyTabulka tabulkaField;

		private string bankaField;

		private string datumField;

		private byte poradiField;

		public kurzyTabulka tabulka
		{
			get
			{
				return this.tabulkaField;
			}
			set
			{
				this.tabulkaField = value;
			}
		}

		public string banka
		{
			get
			{
				return this.bankaField;
			}
			set
			{
				this.bankaField = value;
			}
		}

		public string datum
		{
			get
			{
				return this.datumField;
			}
			set
			{
				this.datumField = value;
			}
		}

		public byte poradi
		{
			get
			{
				return this.poradiField;
			}
			set
			{
				this.poradiField = value;
			}
		}
	}
}