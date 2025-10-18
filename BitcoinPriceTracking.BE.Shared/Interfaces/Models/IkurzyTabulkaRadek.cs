namespace BitcoinPriceTracking.BE.Shared.Interfaces.Models
{
	public interface IkurzyTabulkaRadek
	{
		string kod { get; set; }
		string kurz { get; set; }
		string mena { get; set; }
		ushort mnozstvi { get; set; }
		string zeme { get; set; }
	}
}