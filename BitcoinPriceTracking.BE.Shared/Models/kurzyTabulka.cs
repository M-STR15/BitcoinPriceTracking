namespace BitcoinPriceTracking.BE.Shared.Interfaces.Models
{
	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class kurzyTabulka : IkurzyTabulka
	{

		private kurzyTabulkaRadek[] radekField;

		private string typField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("radek")]
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
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
