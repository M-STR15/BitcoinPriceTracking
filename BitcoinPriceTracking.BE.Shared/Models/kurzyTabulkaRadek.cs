namespace BitcoinPriceTracking.BE.Shared.Interfaces.Models
{
	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class kurzyTabulkaRadek : IkurzyTabulkaRadek
	{

		private string kodField;

		private string menaField;

		private ushort mnozstviField;

		private string kurzField;

		private string zemeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string kod
		{
			get
			{
				return kodField;
			}
			set
			{
				kodField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
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
