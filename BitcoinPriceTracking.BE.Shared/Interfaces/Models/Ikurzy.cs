namespace BitcoinPriceTracking.BE.Shared.Interfaces.Models
{
	public interface Ikurzy
	{
		string banka { get; set; }
		string datum { get; set; }
		byte poradi { get; set; }
		kurzyTabulka tabulka { get; set; }
	}
}