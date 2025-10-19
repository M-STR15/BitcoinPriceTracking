namespace BitcoinPriceTracking.BE.Shared.Models
{
	/// <summary>
	/// Generovaná třída, i datem vytovřeného buildu.
	/// Tato informace slouží pro zobrazení v číla verze.
	/// </summary>
	public class BuildInfo
	{
		public readonly string VersionStr;

		public BuildInfo()
		{
			//TODO: Zjistit verzi z assembly hlavního projektu
			var assembly = System.Reflection.Assembly.GetExecutingAssembly();
			var version = assembly.GetName().Version;
			if (version != null)
				VersionStr = string.Format("v. {0}.{1}.{2}", version.Major, version.Minor, version.Build);
		}
	}
}
