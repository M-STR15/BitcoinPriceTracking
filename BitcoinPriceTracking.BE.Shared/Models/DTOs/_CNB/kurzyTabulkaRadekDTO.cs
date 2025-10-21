namespace BitcoinPriceTracking.BE.Shared.Interfaces.Models
{
	public partial class kurzyTabulkaRadekDTO : IkurzyTabulkaRadek
	{
		private string kodField;

		private string menaField;

		private ushort mnozstviField;

		private string kurzField;

		private string zemeField;

		public string kod
		{
			get
			{
				return this.kodField;
			}
			set
			{
				this.kodField = value;
			}
		}

		public string mena
		{
			get
			{
				return this.menaField;
			}
			set
			{
				this.menaField = value;
			}
		}

		public ushort mnozstvi
		{
			get
			{
				return this.mnozstviField;
			}
			set
			{
				this.mnozstviField = value;
			}
		}

		public string kurz
		{
			get
			{
				return this.kurzField;
			}
			set
			{
				this.kurzField = value;
			}
		}

		public string zeme
		{
			get
			{
				return this.zemeField;
			}
			set
			{
				this.zemeField = value;
			}
		}
	}
}