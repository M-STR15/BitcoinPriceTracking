using BitcoinPriceTracking.BE.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinPriceTracking.BE.Shared.Helpers
{
	public class VersionSWHelper
	{
		public static string GetVersionSW()
		{

			//var assembly = Assembly.GetExecutingAssembly();
			//var version = FileVersionInfo.GetVersionInfo(assembly.Location);
			var version = Assembly.GetExecutingAssembly()?.GetName()?.Version;
			var versionStr = string.Format($"{version.Major}.{version.Minor}.{version.Build}");
			var typeRelease = " DEBUG";
#if RELEASE
			typeRelease = "";
#endif
#if RELEASE_TOS_SERVER
			typeRelease = "";
#endif

			var dateVersion = new BuildInfo().BuildDate?.ToString("yyMMdd") ?? "";
			return string.Format("v{0}.{1}{2}", versionStr, dateVersion, typeRelease);
		}
	}
}
