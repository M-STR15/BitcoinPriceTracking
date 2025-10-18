using BitcoinPriceTracking.BE.Shared.Interfaces.Models;

namespace BitcoinPriceTracking.BE.BusinessLogic.Models
{

	// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class kurzy : Ikurzy
	{

		private kurzyTabulka tabulkaField;

		private string bankaField;

		private string datumField;

		private byte poradiField;

		/// <remarks/>
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
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
