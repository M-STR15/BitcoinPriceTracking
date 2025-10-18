namespace BitcoinPriceTracking.BE.Shared.Interfaces.Models
{
	public interface IkurzyTabulka
	{
		kurzyTabulkaRadek[] radek { get; set; }
		string typ { get; set; }
	}
}