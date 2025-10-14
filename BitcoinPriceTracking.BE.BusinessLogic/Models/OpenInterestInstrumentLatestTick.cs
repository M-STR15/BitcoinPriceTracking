using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinPriceTracking.BE.BusinessLogic.Models
{
	// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
	public class CCSEQ
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CONTRACTCURRENCY
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CONTRACTCURRENCYID
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTDAYHIGHMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTDAYHIGHMARKPRICESETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTDAYHIGHQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTDAYHIGHQUOTEMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTDAYHIGHSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTDAYHIGHSETTLEMENTMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTDAYLOWMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTDAYLOWMARKPRICESETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTDAYLOWQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTDAYLOWQUOTEMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTDAYLOWSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTDAYLOWSETTLEMENTMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTDAYMARKPRICECHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTDAYMARKPRICECHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTDAYOPENMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTDAYOPENQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTDAYOPENSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTDAYQUOTECHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTDAYQUOTECHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTDAYSETTLEMENTCHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTDAYSETTLEMENTCHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTDAYTOTALOPENINTERESTUPDATES
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTHOURHIGHMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTHOURHIGHMARKPRICESETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTHOURHIGHQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTHOURHIGHQUOTEMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTHOURHIGHSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTHOURHIGHSETTLEMENTMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTHOURLOWMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTHOURLOWMARKPRICESETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTHOURLOWQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTHOURLOWQUOTEMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTHOURLOWSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTHOURLOWSETTLEMENTMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTHOURMARKPRICECHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTHOURMARKPRICECHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTHOUROPENMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTHOUROPENQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTHOUROPENSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTHOURQUOTECHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTHOURQUOTECHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTHOURSETTLEMENTCHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTHOURSETTLEMENTCHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTHOURTOTALOPENINTERESTUPDATES
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTMONTHHIGHMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTMONTHHIGHMARKPRICESETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTMONTHHIGHQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTMONTHHIGHQUOTEMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTMONTHHIGHSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTMONTHHIGHSETTLEMENTMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTMONTHLOWMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTMONTHLOWMARKPRICESETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTMONTHLOWQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTMONTHLOWQUOTEMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTMONTHLOWSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTMONTHLOWSETTLEMENTMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTMONTHMARKPRICECHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTMONTHMARKPRICECHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTMONTHOPENMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTMONTHOPENQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTMONTHOPENSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTMONTHQUOTECHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTMONTHQUOTECHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTMONTHSETTLEMENTCHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTMONTHSETTLEMENTCHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTMONTHTOTALOPENINTERESTUPDATES
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTWEEKHIGHMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTWEEKHIGHMARKPRICESETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTWEEKHIGHQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTWEEKHIGHQUOTEMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTWEEKHIGHSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTWEEKHIGHSETTLEMENTMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTWEEKLOWMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTWEEKLOWMARKPRICESETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTWEEKLOWQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTWEEKLOWQUOTEMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTWEEKLOWSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTWEEKLOWSETTLEMENTMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTWEEKMARKPRICECHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTWEEKMARKPRICECHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTWEEKOPENMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTWEEKOPENQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTWEEKOPENSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTWEEKQUOTECHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTWEEKQUOTECHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTWEEKSETTLEMENTCHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTWEEKSETTLEMENTCHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTWEEKTOTALOPENINTERESTUPDATES
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTYEARHIGHMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTYEARHIGHMARKPRICESETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTYEARHIGHQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTYEARHIGHQUOTEMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTYEARHIGHSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTYEARHIGHSETTLEMENTMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTYEARLOWMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTYEARLOWMARKPRICESETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTYEARLOWQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTYEARLOWQUOTEMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTYEARLOWSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTYEARLOWSETTLEMENTMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTYEARMARKPRICECHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTYEARMARKPRICECHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTYEAROPENMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTYEAROPENQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTYEAROPENSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTYEARQUOTECHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTYEARQUOTECHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTYEARSETTLEMENTCHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTYEARSETTLEMENTCHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class CURRENTYEARTOTALOPENINTERESTUPDATES
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class Data
	{
		public string type { get; set; }
		public Properties properties { get; set; }
	}

	public class DENOMINATIONTYPE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class Err
	{
		public string type { get; set; }
		public string description { get; set; }
		public Properties properties { get; set; }
	}

	public class INDEXUNDERLYING
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class INDEXUNDERLYINGID
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class INSTRUMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class Items
	{
		public string type { get; set; }
	}

	public class LASTUPDATECCSEQ
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LASTUPDATEID
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LASTUPDATETS
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LASTUPDATETSNS
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMEFIRSTUPDATETS
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMEHIGHMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMEHIGHMARKPRICESETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMEHIGHMARKPRICETS
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMEHIGHQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMEHIGHQUOTEMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMEHIGHQUOTETS
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMEHIGHSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMEHIGHSETTLEMENTMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMEHIGHSETTLEMENTTS
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMELOWMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMELOWMARKPRICESETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMELOWMARKPRICETS
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMELOWQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMELOWQUOTEMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMELOWQUOTETS
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMELOWSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMELOWSETTLEMENTMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMELOWSETTLEMENTTS
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMEMARKPRICECHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMEMARKPRICECHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMEOPENMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMEOPENQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMEOPENSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMEQUOTECHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMEQUOTECHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMESETTLEMENTCHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMESETTLEMENTCHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class LIFETIMETOTALOPENINTERESTUPDATES
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MAPPEDINSTRUMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MARKET
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class Message
	{
		public string type { get; set; }
		public string description { get; set; }
		public string example { get; set; }
	}

	public class MOVING180DAYHIGHMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING180DAYHIGHMARKPRICESETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING180DAYHIGHQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING180DAYHIGHQUOTEMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING180DAYHIGHSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING180DAYHIGHSETTLEMENTMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING180DAYLOWMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING180DAYLOWMARKPRICESETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING180DAYLOWQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING180DAYLOWQUOTEMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING180DAYLOWSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING180DAYLOWSETTLEMENTMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING180DAYMARKPRICECHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING180DAYMARKPRICECHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING180DAYOPENMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING180DAYOPENQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING180DAYOPENSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING180DAYQUOTECHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING180DAYQUOTECHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING180DAYSETTLEMENTCHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING180DAYSETTLEMENTCHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING180DAYTOTALOPENINTERESTUPDATES
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING24HOURHIGHMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING24HOURHIGHMARKPRICESETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING24HOURHIGHQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING24HOURHIGHQUOTEMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING24HOURHIGHSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING24HOURHIGHSETTLEMENTMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING24HOURLOWMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING24HOURLOWMARKPRICESETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING24HOURLOWQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING24HOURLOWQUOTEMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING24HOURLOWSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING24HOURLOWSETTLEMENTMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING24HOURMARKPRICECHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING24HOURMARKPRICECHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING24HOUROPENMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING24HOUROPENQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING24HOUROPENSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING24HOURQUOTECHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING24HOURQUOTECHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING24HOURSETTLEMENTCHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING24HOURSETTLEMENTCHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING24HOURTOTALOPENINTERESTUPDATES
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING30DAYHIGHMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING30DAYHIGHMARKPRICESETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING30DAYHIGHQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING30DAYHIGHQUOTEMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING30DAYHIGHSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING30DAYHIGHSETTLEMENTMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING30DAYLOWMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING30DAYLOWMARKPRICESETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING30DAYLOWQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING30DAYLOWQUOTEMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING30DAYLOWSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING30DAYLOWSETTLEMENTMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING30DAYMARKPRICECHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING30DAYMARKPRICECHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING30DAYOPENMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING30DAYOPENQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING30DAYOPENSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING30DAYQUOTECHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING30DAYQUOTECHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING30DAYSETTLEMENTCHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING30DAYSETTLEMENTCHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING30DAYTOTALOPENINTERESTUPDATES
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING365DAYHIGHMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING365DAYHIGHMARKPRICESETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING365DAYHIGHQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING365DAYHIGHQUOTEMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING365DAYHIGHSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING365DAYHIGHSETTLEMENTMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING365DAYLOWMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING365DAYLOWMARKPRICESETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING365DAYLOWQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING365DAYLOWQUOTEMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING365DAYLOWSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING365DAYLOWSETTLEMENTMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING365DAYMARKPRICECHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING365DAYMARKPRICECHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING365DAYOPENMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING365DAYOPENQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING365DAYOPENSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING365DAYQUOTECHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING365DAYQUOTECHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING365DAYSETTLEMENTCHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING365DAYSETTLEMENTCHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING365DAYTOTALOPENINTERESTUPDATES
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING7DAYHIGHMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING7DAYHIGHMARKPRICESETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING7DAYHIGHQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING7DAYHIGHQUOTEMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING7DAYHIGHSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING7DAYHIGHSETTLEMENTMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING7DAYLOWMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING7DAYLOWMARKPRICESETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING7DAYLOWQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING7DAYLOWQUOTEMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING7DAYLOWSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING7DAYLOWSETTLEMENTMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING7DAYMARKPRICECHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING7DAYMARKPRICECHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING7DAYOPENMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING7DAYOPENQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING7DAYOPENSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING7DAYQUOTECHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING7DAYQUOTECHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING7DAYSETTLEMENTCHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING7DAYSETTLEMENTCHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING7DAYTOTALOPENINTERESTUPDATES
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING90DAYHIGHMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING90DAYHIGHMARKPRICESETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING90DAYHIGHQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING90DAYHIGHQUOTEMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING90DAYHIGHSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING90DAYHIGHSETTLEMENTMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING90DAYLOWMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING90DAYLOWMARKPRICESETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING90DAYLOWQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING90DAYLOWQUOTEMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING90DAYLOWSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING90DAYLOWSETTLEMENTMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING90DAYMARKPRICECHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING90DAYMARKPRICECHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING90DAYOPENMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING90DAYOPENQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING90DAYOPENSETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING90DAYQUOTECHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING90DAYQUOTECHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING90DAYSETTLEMENTCHANGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING90DAYSETTLEMENTCHANGEPERCENTAGE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class MOVING90DAYTOTALOPENINTERESTUPDATES
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class OtherInfo
	{
		public string type { get; set; }
		public Properties properties { get; set; }
	}

	public class Param
	{
		public string type { get; set; }
		public string description { get; set; }
		public string example { get; set; }
	}

	public class Properties
	{
		public TYPE TYPE { get; set; }
		public MARKET MARKET { get; set; }
		public INSTRUMENT INSTRUMENT { get; set; }
		public MAPPEDINSTRUMENT MAPPED_INSTRUMENT { get; set; }
		public INDEXUNDERLYING INDEX_UNDERLYING { get; set; }
		public QUOTECURRENCY QUOTE_CURRENCY { get; set; }
		public SETTLEMENTCURRENCY SETTLEMENT_CURRENCY { get; set; }
		public CONTRACTCURRENCY CONTRACT_CURRENCY { get; set; }
		public DENOMINATIONTYPE DENOMINATION_TYPE { get; set; }
		public INDEXUNDERLYINGID INDEX_UNDERLYING_ID { get; set; }
		public QUOTECURRENCYID QUOTE_CURRENCY_ID { get; set; }
		public SETTLEMENTCURRENCYID SETTLEMENT_CURRENCY_ID { get; set; }
		public CONTRACTCURRENCYID CONTRACT_CURRENCY_ID { get; set; }
		public TRANSFORMFUNCTION TRANSFORM_FUNCTION { get; set; }
		public CCSEQ CCSEQ { get; set; }
		public VALUESETTLEMENT VALUE_SETTLEMENT { get; set; }
		public VALUESETTLEMENTFLAG VALUE_SETTLEMENT_FLAG { get; set; }
		public VALUEMARKPRICE VALUE_MARK_PRICE { get; set; }
		public VALUEMARKPRICEFLAG VALUE_MARK_PRICE_FLAG { get; set; }
		public VALUEQUOTE VALUE_QUOTE { get; set; }
		public VALUEQUOTEFLAG VALUE_QUOTE_FLAG { get; set; }
		public LASTUPDATETS LAST_UPDATE_TS { get; set; }
		public LASTUPDATETSNS LAST_UPDATE_TS_NS { get; set; }
		public LASTUPDATEID LAST_UPDATE_ID { get; set; }
		public LASTUPDATECCSEQ LAST_UPDATE_CCSEQ { get; set; }
		public CURRENTHOUROPENSETTLEMENT CURRENT_HOUR_OPEN_SETTLEMENT { get; set; }
		public CURRENTHOUROPENMARKPRICE CURRENT_HOUR_OPEN_MARK_PRICE { get; set; }
		public CURRENTHOUROPENQUOTE CURRENT_HOUR_OPEN_QUOTE { get; set; }
		public CURRENTHOURHIGHSETTLEMENT CURRENT_HOUR_HIGH_SETTLEMENT { get; set; }
		public CURRENTHOURHIGHSETTLEMENTMARKPRICE CURRENT_HOUR_HIGH_SETTLEMENT_MARK_PRICE { get; set; }
		public CURRENTHOURHIGHMARKPRICE CURRENT_HOUR_HIGH_MARK_PRICE { get; set; }
		public CURRENTHOURHIGHMARKPRICESETTLEMENT CURRENT_HOUR_HIGH_MARK_PRICE_SETTLEMENT { get; set; }
		public CURRENTHOURHIGHQUOTE CURRENT_HOUR_HIGH_QUOTE { get; set; }
		public CURRENTHOURHIGHQUOTEMARKPRICE CURRENT_HOUR_HIGH_QUOTE_MARK_PRICE { get; set; }
		public CURRENTHOURLOWSETTLEMENT CURRENT_HOUR_LOW_SETTLEMENT { get; set; }
		public CURRENTHOURLOWSETTLEMENTMARKPRICE CURRENT_HOUR_LOW_SETTLEMENT_MARK_PRICE { get; set; }
		public CURRENTHOURLOWMARKPRICE CURRENT_HOUR_LOW_MARK_PRICE { get; set; }
		public CURRENTHOURLOWMARKPRICESETTLEMENT CURRENT_HOUR_LOW_MARK_PRICE_SETTLEMENT { get; set; }
		public CURRENTHOURLOWQUOTE CURRENT_HOUR_LOW_QUOTE { get; set; }
		public CURRENTHOURLOWQUOTEMARKPRICE CURRENT_HOUR_LOW_QUOTE_MARK_PRICE { get; set; }
		public CURRENTHOURTOTALOPENINTERESTUPDATES CURRENT_HOUR_TOTAL_OPEN_INTEREST_UPDATES { get; set; }
		public CURRENTHOURSETTLEMENTCHANGE CURRENT_HOUR_SETTLEMENT_CHANGE { get; set; }
		public CURRENTHOURMARKPRICECHANGE CURRENT_HOUR_MARK_PRICE_CHANGE { get; set; }
		public CURRENTHOURQUOTECHANGE CURRENT_HOUR_QUOTE_CHANGE { get; set; }
		public CURRENTHOURSETTLEMENTCHANGEPERCENTAGE CURRENT_HOUR_SETTLEMENT_CHANGE_PERCENTAGE { get; set; }
		public CURRENTHOURMARKPRICECHANGEPERCENTAGE CURRENT_HOUR_MARK_PRICE_CHANGE_PERCENTAGE { get; set; }
		public CURRENTHOURQUOTECHANGEPERCENTAGE CURRENT_HOUR_QUOTE_CHANGE_PERCENTAGE { get; set; }
		public CURRENTDAYOPENSETTLEMENT CURRENT_DAY_OPEN_SETTLEMENT { get; set; }
		public CURRENTDAYOPENMARKPRICE CURRENT_DAY_OPEN_MARK_PRICE { get; set; }
		public CURRENTDAYOPENQUOTE CURRENT_DAY_OPEN_QUOTE { get; set; }
		public CURRENTDAYHIGHSETTLEMENT CURRENT_DAY_HIGH_SETTLEMENT { get; set; }
		public CURRENTDAYHIGHSETTLEMENTMARKPRICE CURRENT_DAY_HIGH_SETTLEMENT_MARK_PRICE { get; set; }
		public CURRENTDAYHIGHMARKPRICE CURRENT_DAY_HIGH_MARK_PRICE { get; set; }
		public CURRENTDAYHIGHMARKPRICESETTLEMENT CURRENT_DAY_HIGH_MARK_PRICE_SETTLEMENT { get; set; }
		public CURRENTDAYHIGHQUOTE CURRENT_DAY_HIGH_QUOTE { get; set; }
		public CURRENTDAYHIGHQUOTEMARKPRICE CURRENT_DAY_HIGH_QUOTE_MARK_PRICE { get; set; }
		public CURRENTDAYLOWSETTLEMENT CURRENT_DAY_LOW_SETTLEMENT { get; set; }
		public CURRENTDAYLOWSETTLEMENTMARKPRICE CURRENT_DAY_LOW_SETTLEMENT_MARK_PRICE { get; set; }
		public CURRENTDAYLOWMARKPRICE CURRENT_DAY_LOW_MARK_PRICE { get; set; }
		public CURRENTDAYLOWMARKPRICESETTLEMENT CURRENT_DAY_LOW_MARK_PRICE_SETTLEMENT { get; set; }
		public CURRENTDAYLOWQUOTE CURRENT_DAY_LOW_QUOTE { get; set; }
		public CURRENTDAYLOWQUOTEMARKPRICE CURRENT_DAY_LOW_QUOTE_MARK_PRICE { get; set; }
		public CURRENTDAYTOTALOPENINTERESTUPDATES CURRENT_DAY_TOTAL_OPEN_INTEREST_UPDATES { get; set; }
		public CURRENTDAYSETTLEMENTCHANGE CURRENT_DAY_SETTLEMENT_CHANGE { get; set; }
		public CURRENTDAYMARKPRICECHANGE CURRENT_DAY_MARK_PRICE_CHANGE { get; set; }
		public CURRENTDAYQUOTECHANGE CURRENT_DAY_QUOTE_CHANGE { get; set; }
		public CURRENTDAYSETTLEMENTCHANGEPERCENTAGE CURRENT_DAY_SETTLEMENT_CHANGE_PERCENTAGE { get; set; }
		public CURRENTDAYMARKPRICECHANGEPERCENTAGE CURRENT_DAY_MARK_PRICE_CHANGE_PERCENTAGE { get; set; }
		public CURRENTDAYQUOTECHANGEPERCENTAGE CURRENT_DAY_QUOTE_CHANGE_PERCENTAGE { get; set; }
		public CURRENTWEEKOPENSETTLEMENT CURRENT_WEEK_OPEN_SETTLEMENT { get; set; }
		public CURRENTWEEKOPENMARKPRICE CURRENT_WEEK_OPEN_MARK_PRICE { get; set; }
		public CURRENTWEEKOPENQUOTE CURRENT_WEEK_OPEN_QUOTE { get; set; }
		public CURRENTWEEKHIGHSETTLEMENT CURRENT_WEEK_HIGH_SETTLEMENT { get; set; }
		public CURRENTWEEKHIGHSETTLEMENTMARKPRICE CURRENT_WEEK_HIGH_SETTLEMENT_MARK_PRICE { get; set; }
		public CURRENTWEEKHIGHMARKPRICE CURRENT_WEEK_HIGH_MARK_PRICE { get; set; }
		public CURRENTWEEKHIGHMARKPRICESETTLEMENT CURRENT_WEEK_HIGH_MARK_PRICE_SETTLEMENT { get; set; }
		public CURRENTWEEKHIGHQUOTE CURRENT_WEEK_HIGH_QUOTE { get; set; }
		public CURRENTWEEKHIGHQUOTEMARKPRICE CURRENT_WEEK_HIGH_QUOTE_MARK_PRICE { get; set; }
		public CURRENTWEEKLOWSETTLEMENT CURRENT_WEEK_LOW_SETTLEMENT { get; set; }
		public CURRENTWEEKLOWSETTLEMENTMARKPRICE CURRENT_WEEK_LOW_SETTLEMENT_MARK_PRICE { get; set; }
		public CURRENTWEEKLOWMARKPRICE CURRENT_WEEK_LOW_MARK_PRICE { get; set; }
		public CURRENTWEEKLOWMARKPRICESETTLEMENT CURRENT_WEEK_LOW_MARK_PRICE_SETTLEMENT { get; set; }
		public CURRENTWEEKLOWQUOTE CURRENT_WEEK_LOW_QUOTE { get; set; }
		public CURRENTWEEKLOWQUOTEMARKPRICE CURRENT_WEEK_LOW_QUOTE_MARK_PRICE { get; set; }
		public CURRENTWEEKTOTALOPENINTERESTUPDATES CURRENT_WEEK_TOTAL_OPEN_INTEREST_UPDATES { get; set; }
		public CURRENTWEEKSETTLEMENTCHANGE CURRENT_WEEK_SETTLEMENT_CHANGE { get; set; }
		public CURRENTWEEKMARKPRICECHANGE CURRENT_WEEK_MARK_PRICE_CHANGE { get; set; }
		public CURRENTWEEKQUOTECHANGE CURRENT_WEEK_QUOTE_CHANGE { get; set; }
		public CURRENTWEEKSETTLEMENTCHANGEPERCENTAGE CURRENT_WEEK_SETTLEMENT_CHANGE_PERCENTAGE { get; set; }
		public CURRENTWEEKMARKPRICECHANGEPERCENTAGE CURRENT_WEEK_MARK_PRICE_CHANGE_PERCENTAGE { get; set; }
		public CURRENTWEEKQUOTECHANGEPERCENTAGE CURRENT_WEEK_QUOTE_CHANGE_PERCENTAGE { get; set; }
		public CURRENTMONTHOPENSETTLEMENT CURRENT_MONTH_OPEN_SETTLEMENT { get; set; }
		public CURRENTMONTHOPENMARKPRICE CURRENT_MONTH_OPEN_MARK_PRICE { get; set; }
		public CURRENTMONTHOPENQUOTE CURRENT_MONTH_OPEN_QUOTE { get; set; }
		public CURRENTMONTHHIGHSETTLEMENT CURRENT_MONTH_HIGH_SETTLEMENT { get; set; }
		public CURRENTMONTHHIGHSETTLEMENTMARKPRICE CURRENT_MONTH_HIGH_SETTLEMENT_MARK_PRICE { get; set; }
		public CURRENTMONTHHIGHMARKPRICE CURRENT_MONTH_HIGH_MARK_PRICE { get; set; }
		public CURRENTMONTHHIGHMARKPRICESETTLEMENT CURRENT_MONTH_HIGH_MARK_PRICE_SETTLEMENT { get; set; }
		public CURRENTMONTHHIGHQUOTE CURRENT_MONTH_HIGH_QUOTE { get; set; }
		public CURRENTMONTHHIGHQUOTEMARKPRICE CURRENT_MONTH_HIGH_QUOTE_MARK_PRICE { get; set; }
		public CURRENTMONTHLOWSETTLEMENT CURRENT_MONTH_LOW_SETTLEMENT { get; set; }
		public CURRENTMONTHLOWSETTLEMENTMARKPRICE CURRENT_MONTH_LOW_SETTLEMENT_MARK_PRICE { get; set; }
		public CURRENTMONTHLOWMARKPRICE CURRENT_MONTH_LOW_MARK_PRICE { get; set; }
		public CURRENTMONTHLOWMARKPRICESETTLEMENT CURRENT_MONTH_LOW_MARK_PRICE_SETTLEMENT { get; set; }
		public CURRENTMONTHLOWQUOTE CURRENT_MONTH_LOW_QUOTE { get; set; }
		public CURRENTMONTHLOWQUOTEMARKPRICE CURRENT_MONTH_LOW_QUOTE_MARK_PRICE { get; set; }
		public CURRENTMONTHTOTALOPENINTERESTUPDATES CURRENT_MONTH_TOTAL_OPEN_INTEREST_UPDATES { get; set; }
		public CURRENTMONTHSETTLEMENTCHANGE CURRENT_MONTH_SETTLEMENT_CHANGE { get; set; }
		public CURRENTMONTHMARKPRICECHANGE CURRENT_MONTH_MARK_PRICE_CHANGE { get; set; }
		public CURRENTMONTHQUOTECHANGE CURRENT_MONTH_QUOTE_CHANGE { get; set; }
		public CURRENTMONTHSETTLEMENTCHANGEPERCENTAGE CURRENT_MONTH_SETTLEMENT_CHANGE_PERCENTAGE { get; set; }
		public CURRENTMONTHMARKPRICECHANGEPERCENTAGE CURRENT_MONTH_MARK_PRICE_CHANGE_PERCENTAGE { get; set; }
		public CURRENTMONTHQUOTECHANGEPERCENTAGE CURRENT_MONTH_QUOTE_CHANGE_PERCENTAGE { get; set; }
		public CURRENTYEAROPENSETTLEMENT CURRENT_YEAR_OPEN_SETTLEMENT { get; set; }
		public CURRENTYEAROPENMARKPRICE CURRENT_YEAR_OPEN_MARK_PRICE { get; set; }
		public CURRENTYEAROPENQUOTE CURRENT_YEAR_OPEN_QUOTE { get; set; }
		public CURRENTYEARHIGHSETTLEMENT CURRENT_YEAR_HIGH_SETTLEMENT { get; set; }
		public CURRENTYEARHIGHSETTLEMENTMARKPRICE CURRENT_YEAR_HIGH_SETTLEMENT_MARK_PRICE { get; set; }
		public CURRENTYEARHIGHMARKPRICE CURRENT_YEAR_HIGH_MARK_PRICE { get; set; }
		public CURRENTYEARHIGHMARKPRICESETTLEMENT CURRENT_YEAR_HIGH_MARK_PRICE_SETTLEMENT { get; set; }
		public CURRENTYEARHIGHQUOTE CURRENT_YEAR_HIGH_QUOTE { get; set; }
		public CURRENTYEARHIGHQUOTEMARKPRICE CURRENT_YEAR_HIGH_QUOTE_MARK_PRICE { get; set; }
		public CURRENTYEARLOWSETTLEMENT CURRENT_YEAR_LOW_SETTLEMENT { get; set; }
		public CURRENTYEARLOWSETTLEMENTMARKPRICE CURRENT_YEAR_LOW_SETTLEMENT_MARK_PRICE { get; set; }
		public CURRENTYEARLOWMARKPRICE CURRENT_YEAR_LOW_MARK_PRICE { get; set; }
		public CURRENTYEARLOWMARKPRICESETTLEMENT CURRENT_YEAR_LOW_MARK_PRICE_SETTLEMENT { get; set; }
		public CURRENTYEARLOWQUOTE CURRENT_YEAR_LOW_QUOTE { get; set; }
		public CURRENTYEARLOWQUOTEMARKPRICE CURRENT_YEAR_LOW_QUOTE_MARK_PRICE { get; set; }
		public CURRENTYEARTOTALOPENINTERESTUPDATES CURRENT_YEAR_TOTAL_OPEN_INTEREST_UPDATES { get; set; }
		public CURRENTYEARSETTLEMENTCHANGE CURRENT_YEAR_SETTLEMENT_CHANGE { get; set; }
		public CURRENTYEARMARKPRICECHANGE CURRENT_YEAR_MARK_PRICE_CHANGE { get; set; }
		public CURRENTYEARQUOTECHANGE CURRENT_YEAR_QUOTE_CHANGE { get; set; }
		public CURRENTYEARSETTLEMENTCHANGEPERCENTAGE CURRENT_YEAR_SETTLEMENT_CHANGE_PERCENTAGE { get; set; }
		public CURRENTYEARMARKPRICECHANGEPERCENTAGE CURRENT_YEAR_MARK_PRICE_CHANGE_PERCENTAGE { get; set; }
		public CURRENTYEARQUOTECHANGEPERCENTAGE CURRENT_YEAR_QUOTE_CHANGE_PERCENTAGE { get; set; }
		public MOVING24HOUROPENSETTLEMENT MOVING_24_HOUR_OPEN_SETTLEMENT { get; set; }
		public MOVING24HOUROPENMARKPRICE MOVING_24_HOUR_OPEN_MARK_PRICE { get; set; }
		public MOVING24HOUROPENQUOTE MOVING_24_HOUR_OPEN_QUOTE { get; set; }
		public MOVING24HOURHIGHSETTLEMENT MOVING_24_HOUR_HIGH_SETTLEMENT { get; set; }
		public MOVING24HOURHIGHSETTLEMENTMARKPRICE MOVING_24_HOUR_HIGH_SETTLEMENT_MARK_PRICE { get; set; }
		public MOVING24HOURHIGHMARKPRICE MOVING_24_HOUR_HIGH_MARK_PRICE { get; set; }
		public MOVING24HOURHIGHMARKPRICESETTLEMENT MOVING_24_HOUR_HIGH_MARK_PRICE_SETTLEMENT { get; set; }
		public MOVING24HOURHIGHQUOTE MOVING_24_HOUR_HIGH_QUOTE { get; set; }
		public MOVING24HOURHIGHQUOTEMARKPRICE MOVING_24_HOUR_HIGH_QUOTE_MARK_PRICE { get; set; }
		public MOVING24HOURLOWSETTLEMENT MOVING_24_HOUR_LOW_SETTLEMENT { get; set; }
		public MOVING24HOURLOWSETTLEMENTMARKPRICE MOVING_24_HOUR_LOW_SETTLEMENT_MARK_PRICE { get; set; }
		public MOVING24HOURLOWMARKPRICE MOVING_24_HOUR_LOW_MARK_PRICE { get; set; }
		public MOVING24HOURLOWMARKPRICESETTLEMENT MOVING_24_HOUR_LOW_MARK_PRICE_SETTLEMENT { get; set; }
		public MOVING24HOURLOWQUOTE MOVING_24_HOUR_LOW_QUOTE { get; set; }
		public MOVING24HOURLOWQUOTEMARKPRICE MOVING_24_HOUR_LOW_QUOTE_MARK_PRICE { get; set; }
		public MOVING24HOURTOTALOPENINTERESTUPDATES MOVING_24_HOUR_TOTAL_OPEN_INTEREST_UPDATES { get; set; }
		public MOVING24HOURSETTLEMENTCHANGE MOVING_24_HOUR_SETTLEMENT_CHANGE { get; set; }
		public MOVING24HOURMARKPRICECHANGE MOVING_24_HOUR_MARK_PRICE_CHANGE { get; set; }
		public MOVING24HOURQUOTECHANGE MOVING_24_HOUR_QUOTE_CHANGE { get; set; }
		public MOVING24HOURSETTLEMENTCHANGEPERCENTAGE MOVING_24_HOUR_SETTLEMENT_CHANGE_PERCENTAGE { get; set; }
		public MOVING24HOURMARKPRICECHANGEPERCENTAGE MOVING_24_HOUR_MARK_PRICE_CHANGE_PERCENTAGE { get; set; }
		public MOVING24HOURQUOTECHANGEPERCENTAGE MOVING_24_HOUR_QUOTE_CHANGE_PERCENTAGE { get; set; }
		public MOVING7DAYOPENSETTLEMENT MOVING_7_DAY_OPEN_SETTLEMENT { get; set; }
		public MOVING7DAYOPENMARKPRICE MOVING_7_DAY_OPEN_MARK_PRICE { get; set; }
		public MOVING7DAYOPENQUOTE MOVING_7_DAY_OPEN_QUOTE { get; set; }
		public MOVING7DAYHIGHSETTLEMENT MOVING_7_DAY_HIGH_SETTLEMENT { get; set; }
		public MOVING7DAYHIGHSETTLEMENTMARKPRICE MOVING_7_DAY_HIGH_SETTLEMENT_MARK_PRICE { get; set; }
		public MOVING7DAYHIGHMARKPRICE MOVING_7_DAY_HIGH_MARK_PRICE { get; set; }
		public MOVING7DAYHIGHMARKPRICESETTLEMENT MOVING_7_DAY_HIGH_MARK_PRICE_SETTLEMENT { get; set; }
		public MOVING7DAYHIGHQUOTE MOVING_7_DAY_HIGH_QUOTE { get; set; }
		public MOVING7DAYHIGHQUOTEMARKPRICE MOVING_7_DAY_HIGH_QUOTE_MARK_PRICE { get; set; }
		public MOVING7DAYLOWSETTLEMENT MOVING_7_DAY_LOW_SETTLEMENT { get; set; }
		public MOVING7DAYLOWSETTLEMENTMARKPRICE MOVING_7_DAY_LOW_SETTLEMENT_MARK_PRICE { get; set; }
		public MOVING7DAYLOWMARKPRICE MOVING_7_DAY_LOW_MARK_PRICE { get; set; }
		public MOVING7DAYLOWMARKPRICESETTLEMENT MOVING_7_DAY_LOW_MARK_PRICE_SETTLEMENT { get; set; }
		public MOVING7DAYLOWQUOTE MOVING_7_DAY_LOW_QUOTE { get; set; }
		public MOVING7DAYLOWQUOTEMARKPRICE MOVING_7_DAY_LOW_QUOTE_MARK_PRICE { get; set; }
		public MOVING7DAYTOTALOPENINTERESTUPDATES MOVING_7_DAY_TOTAL_OPEN_INTEREST_UPDATES { get; set; }
		public MOVING7DAYSETTLEMENTCHANGE MOVING_7_DAY_SETTLEMENT_CHANGE { get; set; }
		public MOVING7DAYMARKPRICECHANGE MOVING_7_DAY_MARK_PRICE_CHANGE { get; set; }
		public MOVING7DAYQUOTECHANGE MOVING_7_DAY_QUOTE_CHANGE { get; set; }
		public MOVING7DAYSETTLEMENTCHANGEPERCENTAGE MOVING_7_DAY_SETTLEMENT_CHANGE_PERCENTAGE { get; set; }
		public MOVING7DAYMARKPRICECHANGEPERCENTAGE MOVING_7_DAY_MARK_PRICE_CHANGE_PERCENTAGE { get; set; }
		public MOVING7DAYQUOTECHANGEPERCENTAGE MOVING_7_DAY_QUOTE_CHANGE_PERCENTAGE { get; set; }
		public MOVING30DAYOPENSETTLEMENT MOVING_30_DAY_OPEN_SETTLEMENT { get; set; }
		public MOVING30DAYOPENMARKPRICE MOVING_30_DAY_OPEN_MARK_PRICE { get; set; }
		public MOVING30DAYOPENQUOTE MOVING_30_DAY_OPEN_QUOTE { get; set; }
		public MOVING30DAYHIGHSETTLEMENT MOVING_30_DAY_HIGH_SETTLEMENT { get; set; }
		public MOVING30DAYHIGHSETTLEMENTMARKPRICE MOVING_30_DAY_HIGH_SETTLEMENT_MARK_PRICE { get; set; }
		public MOVING30DAYHIGHMARKPRICE MOVING_30_DAY_HIGH_MARK_PRICE { get; set; }
		public MOVING30DAYHIGHMARKPRICESETTLEMENT MOVING_30_DAY_HIGH_MARK_PRICE_SETTLEMENT { get; set; }
		public MOVING30DAYHIGHQUOTE MOVING_30_DAY_HIGH_QUOTE { get; set; }
		public MOVING30DAYHIGHQUOTEMARKPRICE MOVING_30_DAY_HIGH_QUOTE_MARK_PRICE { get; set; }
		public MOVING30DAYLOWSETTLEMENT MOVING_30_DAY_LOW_SETTLEMENT { get; set; }
		public MOVING30DAYLOWSETTLEMENTMARKPRICE MOVING_30_DAY_LOW_SETTLEMENT_MARK_PRICE { get; set; }
		public MOVING30DAYLOWMARKPRICE MOVING_30_DAY_LOW_MARK_PRICE { get; set; }
		public MOVING30DAYLOWMARKPRICESETTLEMENT MOVING_30_DAY_LOW_MARK_PRICE_SETTLEMENT { get; set; }
		public MOVING30DAYLOWQUOTE MOVING_30_DAY_LOW_QUOTE { get; set; }
		public MOVING30DAYLOWQUOTEMARKPRICE MOVING_30_DAY_LOW_QUOTE_MARK_PRICE { get; set; }
		public MOVING30DAYTOTALOPENINTERESTUPDATES MOVING_30_DAY_TOTAL_OPEN_INTEREST_UPDATES { get; set; }
		public MOVING30DAYSETTLEMENTCHANGE MOVING_30_DAY_SETTLEMENT_CHANGE { get; set; }
		public MOVING30DAYMARKPRICECHANGE MOVING_30_DAY_MARK_PRICE_CHANGE { get; set; }
		public MOVING30DAYQUOTECHANGE MOVING_30_DAY_QUOTE_CHANGE { get; set; }
		public MOVING30DAYSETTLEMENTCHANGEPERCENTAGE MOVING_30_DAY_SETTLEMENT_CHANGE_PERCENTAGE { get; set; }
		public MOVING30DAYMARKPRICECHANGEPERCENTAGE MOVING_30_DAY_MARK_PRICE_CHANGE_PERCENTAGE { get; set; }
		public MOVING30DAYQUOTECHANGEPERCENTAGE MOVING_30_DAY_QUOTE_CHANGE_PERCENTAGE { get; set; }
		public MOVING90DAYOPENSETTLEMENT MOVING_90_DAY_OPEN_SETTLEMENT { get; set; }
		public MOVING90DAYOPENMARKPRICE MOVING_90_DAY_OPEN_MARK_PRICE { get; set; }
		public MOVING90DAYOPENQUOTE MOVING_90_DAY_OPEN_QUOTE { get; set; }
		public MOVING90DAYHIGHSETTLEMENT MOVING_90_DAY_HIGH_SETTLEMENT { get; set; }
		public MOVING90DAYHIGHSETTLEMENTMARKPRICE MOVING_90_DAY_HIGH_SETTLEMENT_MARK_PRICE { get; set; }
		public MOVING90DAYHIGHMARKPRICE MOVING_90_DAY_HIGH_MARK_PRICE { get; set; }
		public MOVING90DAYHIGHMARKPRICESETTLEMENT MOVING_90_DAY_HIGH_MARK_PRICE_SETTLEMENT { get; set; }
		public MOVING90DAYHIGHQUOTE MOVING_90_DAY_HIGH_QUOTE { get; set; }
		public MOVING90DAYHIGHQUOTEMARKPRICE MOVING_90_DAY_HIGH_QUOTE_MARK_PRICE { get; set; }
		public MOVING90DAYLOWSETTLEMENT MOVING_90_DAY_LOW_SETTLEMENT { get; set; }
		public MOVING90DAYLOWSETTLEMENTMARKPRICE MOVING_90_DAY_LOW_SETTLEMENT_MARK_PRICE { get; set; }
		public MOVING90DAYLOWMARKPRICE MOVING_90_DAY_LOW_MARK_PRICE { get; set; }
		public MOVING90DAYLOWMARKPRICESETTLEMENT MOVING_90_DAY_LOW_MARK_PRICE_SETTLEMENT { get; set; }
		public MOVING90DAYLOWQUOTE MOVING_90_DAY_LOW_QUOTE { get; set; }
		public MOVING90DAYLOWQUOTEMARKPRICE MOVING_90_DAY_LOW_QUOTE_MARK_PRICE { get; set; }
		public MOVING90DAYTOTALOPENINTERESTUPDATES MOVING_90_DAY_TOTAL_OPEN_INTEREST_UPDATES { get; set; }
		public MOVING90DAYSETTLEMENTCHANGE MOVING_90_DAY_SETTLEMENT_CHANGE { get; set; }
		public MOVING90DAYMARKPRICECHANGE MOVING_90_DAY_MARK_PRICE_CHANGE { get; set; }
		public MOVING90DAYQUOTECHANGE MOVING_90_DAY_QUOTE_CHANGE { get; set; }
		public MOVING90DAYSETTLEMENTCHANGEPERCENTAGE MOVING_90_DAY_SETTLEMENT_CHANGE_PERCENTAGE { get; set; }
		public MOVING90DAYMARKPRICECHANGEPERCENTAGE MOVING_90_DAY_MARK_PRICE_CHANGE_PERCENTAGE { get; set; }
		public MOVING90DAYQUOTECHANGEPERCENTAGE MOVING_90_DAY_QUOTE_CHANGE_PERCENTAGE { get; set; }
		public MOVING180DAYOPENSETTLEMENT MOVING_180_DAY_OPEN_SETTLEMENT { get; set; }
		public MOVING180DAYOPENMARKPRICE MOVING_180_DAY_OPEN_MARK_PRICE { get; set; }
		public MOVING180DAYOPENQUOTE MOVING_180_DAY_OPEN_QUOTE { get; set; }
		public MOVING180DAYHIGHSETTLEMENT MOVING_180_DAY_HIGH_SETTLEMENT { get; set; }
		public MOVING180DAYHIGHSETTLEMENTMARKPRICE MOVING_180_DAY_HIGH_SETTLEMENT_MARK_PRICE { get; set; }
		public MOVING180DAYHIGHMARKPRICE MOVING_180_DAY_HIGH_MARK_PRICE { get; set; }
		public MOVING180DAYHIGHMARKPRICESETTLEMENT MOVING_180_DAY_HIGH_MARK_PRICE_SETTLEMENT { get; set; }
		public MOVING180DAYHIGHQUOTE MOVING_180_DAY_HIGH_QUOTE { get; set; }
		public MOVING180DAYHIGHQUOTEMARKPRICE MOVING_180_DAY_HIGH_QUOTE_MARK_PRICE { get; set; }
		public MOVING180DAYLOWSETTLEMENT MOVING_180_DAY_LOW_SETTLEMENT { get; set; }
		public MOVING180DAYLOWSETTLEMENTMARKPRICE MOVING_180_DAY_LOW_SETTLEMENT_MARK_PRICE { get; set; }
		public MOVING180DAYLOWMARKPRICE MOVING_180_DAY_LOW_MARK_PRICE { get; set; }
		public MOVING180DAYLOWMARKPRICESETTLEMENT MOVING_180_DAY_LOW_MARK_PRICE_SETTLEMENT { get; set; }
		public MOVING180DAYLOWQUOTE MOVING_180_DAY_LOW_QUOTE { get; set; }
		public MOVING180DAYLOWQUOTEMARKPRICE MOVING_180_DAY_LOW_QUOTE_MARK_PRICE { get; set; }
		public MOVING180DAYTOTALOPENINTERESTUPDATES MOVING_180_DAY_TOTAL_OPEN_INTEREST_UPDATES { get; set; }
		public MOVING180DAYSETTLEMENTCHANGE MOVING_180_DAY_SETTLEMENT_CHANGE { get; set; }
		public MOVING180DAYMARKPRICECHANGE MOVING_180_DAY_MARK_PRICE_CHANGE { get; set; }
		public MOVING180DAYQUOTECHANGE MOVING_180_DAY_QUOTE_CHANGE { get; set; }
		public MOVING180DAYSETTLEMENTCHANGEPERCENTAGE MOVING_180_DAY_SETTLEMENT_CHANGE_PERCENTAGE { get; set; }
		public MOVING180DAYMARKPRICECHANGEPERCENTAGE MOVING_180_DAY_MARK_PRICE_CHANGE_PERCENTAGE { get; set; }
		public MOVING180DAYQUOTECHANGEPERCENTAGE MOVING_180_DAY_QUOTE_CHANGE_PERCENTAGE { get; set; }
		public MOVING365DAYOPENSETTLEMENT MOVING_365_DAY_OPEN_SETTLEMENT { get; set; }
		public MOVING365DAYOPENMARKPRICE MOVING_365_DAY_OPEN_MARK_PRICE { get; set; }
		public MOVING365DAYOPENQUOTE MOVING_365_DAY_OPEN_QUOTE { get; set; }
		public MOVING365DAYHIGHSETTLEMENT MOVING_365_DAY_HIGH_SETTLEMENT { get; set; }
		public MOVING365DAYHIGHSETTLEMENTMARKPRICE MOVING_365_DAY_HIGH_SETTLEMENT_MARK_PRICE { get; set; }
		public MOVING365DAYHIGHMARKPRICE MOVING_365_DAY_HIGH_MARK_PRICE { get; set; }
		public MOVING365DAYHIGHMARKPRICESETTLEMENT MOVING_365_DAY_HIGH_MARK_PRICE_SETTLEMENT { get; set; }
		public MOVING365DAYHIGHQUOTE MOVING_365_DAY_HIGH_QUOTE { get; set; }
		public MOVING365DAYHIGHQUOTEMARKPRICE MOVING_365_DAY_HIGH_QUOTE_MARK_PRICE { get; set; }
		public MOVING365DAYLOWSETTLEMENT MOVING_365_DAY_LOW_SETTLEMENT { get; set; }
		public MOVING365DAYLOWSETTLEMENTMARKPRICE MOVING_365_DAY_LOW_SETTLEMENT_MARK_PRICE { get; set; }
		public MOVING365DAYLOWMARKPRICE MOVING_365_DAY_LOW_MARK_PRICE { get; set; }
		public MOVING365DAYLOWMARKPRICESETTLEMENT MOVING_365_DAY_LOW_MARK_PRICE_SETTLEMENT { get; set; }
		public MOVING365DAYLOWQUOTE MOVING_365_DAY_LOW_QUOTE { get; set; }
		public MOVING365DAYLOWQUOTEMARKPRICE MOVING_365_DAY_LOW_QUOTE_MARK_PRICE { get; set; }
		public MOVING365DAYTOTALOPENINTERESTUPDATES MOVING_365_DAY_TOTAL_OPEN_INTEREST_UPDATES { get; set; }
		public MOVING365DAYSETTLEMENTCHANGE MOVING_365_DAY_SETTLEMENT_CHANGE { get; set; }
		public MOVING365DAYMARKPRICECHANGE MOVING_365_DAY_MARK_PRICE_CHANGE { get; set; }
		public MOVING365DAYQUOTECHANGE MOVING_365_DAY_QUOTE_CHANGE { get; set; }
		public MOVING365DAYSETTLEMENTCHANGEPERCENTAGE MOVING_365_DAY_SETTLEMENT_CHANGE_PERCENTAGE { get; set; }
		public MOVING365DAYMARKPRICECHANGEPERCENTAGE MOVING_365_DAY_MARK_PRICE_CHANGE_PERCENTAGE { get; set; }
		public MOVING365DAYQUOTECHANGEPERCENTAGE MOVING_365_DAY_QUOTE_CHANGE_PERCENTAGE { get; set; }
		public LIFETIMEFIRSTUPDATETS LIFETIME_FIRST_UPDATE_TS { get; set; }
		public LIFETIMEOPENSETTLEMENT LIFETIME_OPEN_SETTLEMENT { get; set; }
		public LIFETIMEOPENMARKPRICE LIFETIME_OPEN_MARK_PRICE { get; set; }
		public LIFETIMEOPENQUOTE LIFETIME_OPEN_QUOTE { get; set; }
		public LIFETIMEHIGHSETTLEMENT LIFETIME_HIGH_SETTLEMENT { get; set; }
		public LIFETIMEHIGHSETTLEMENTMARKPRICE LIFETIME_HIGH_SETTLEMENT_MARK_PRICE { get; set; }
		public LIFETIMEHIGHSETTLEMENTTS LIFETIME_HIGH_SETTLEMENT_TS { get; set; }
		public LIFETIMEHIGHMARKPRICE LIFETIME_HIGH_MARK_PRICE { get; set; }
		public LIFETIMEHIGHMARKPRICESETTLEMENT LIFETIME_HIGH_MARK_PRICE_SETTLEMENT { get; set; }
		public LIFETIMEHIGHMARKPRICETS LIFETIME_HIGH_MARK_PRICE_TS { get; set; }
		public LIFETIMEHIGHQUOTE LIFETIME_HIGH_QUOTE { get; set; }
		public LIFETIMEHIGHQUOTEMARKPRICE LIFETIME_HIGH_QUOTE_MARK_PRICE { get; set; }
		public LIFETIMEHIGHQUOTETS LIFETIME_HIGH_QUOTE_TS { get; set; }
		public LIFETIMELOWSETTLEMENT LIFETIME_LOW_SETTLEMENT { get; set; }
		public LIFETIMELOWSETTLEMENTMARKPRICE LIFETIME_LOW_SETTLEMENT_MARK_PRICE { get; set; }
		public LIFETIMELOWSETTLEMENTTS LIFETIME_LOW_SETTLEMENT_TS { get; set; }
		public LIFETIMELOWMARKPRICE LIFETIME_LOW_MARK_PRICE { get; set; }
		public LIFETIMELOWMARKPRICESETTLEMENT LIFETIME_LOW_MARK_PRICE_SETTLEMENT { get; set; }
		public LIFETIMELOWMARKPRICETS LIFETIME_LOW_MARK_PRICE_TS { get; set; }
		public LIFETIMELOWQUOTE LIFETIME_LOW_QUOTE { get; set; }
		public LIFETIMELOWQUOTEMARKPRICE LIFETIME_LOW_QUOTE_MARK_PRICE { get; set; }
		public LIFETIMELOWQUOTETS LIFETIME_LOW_QUOTE_TS { get; set; }
		public LIFETIMETOTALOPENINTERESTUPDATES LIFETIME_TOTAL_OPEN_INTEREST_UPDATES { get; set; }
		public LIFETIMESETTLEMENTCHANGE LIFETIME_SETTLEMENT_CHANGE { get; set; }
		public LIFETIMEMARKPRICECHANGE LIFETIME_MARK_PRICE_CHANGE { get; set; }
		public LIFETIMEQUOTECHANGE LIFETIME_QUOTE_CHANGE { get; set; }
		public LIFETIMESETTLEMENTCHANGEPERCENTAGE LIFETIME_SETTLEMENT_CHANGE_PERCENTAGE { get; set; }
		public LIFETIMEMARKPRICECHANGEPERCENTAGE LIFETIME_MARK_PRICE_CHANGE_PERCENTAGE { get; set; }
		public LIFETIMEQUOTECHANGEPERCENTAGE LIFETIME_QUOTE_CHANGE_PERCENTAGE { get; set; }
		public Type type { get; set; }
		public Message message { get; set; }
		public OtherInfo other_info { get; set; }
		public Param param { get; set; }
		public Values values { get; set; }
	}

	public class QUOTECURRENCY
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class QUOTECURRENCYID
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class Root
	{
		public Data Data { get; set; }
		public Err Err { get; set; }
	}

	public class SETTLEMENTCURRENCY
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class SETTLEMENTCURRENCYID
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class TRANSFORMFUNCTION
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class TYPE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class Type2
	{
		public string type { get; set; }
		public string description { get; set; }
		public string format { get; set; }
		public int example { get; set; }
	}

	public class VALUEMARKPRICE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class VALUEMARKPRICEFLAG
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class VALUEQUOTE
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class VALUEQUOTEFLAG
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class Values
	{
		public string type { get; set; }
		public string description { get; set; }
		public List<string> example { get; set; }
		public Items items { get; set; }
	}

	public class VALUESETTLEMENT
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}

	public class VALUESETTLEMENTFLAG
	{
		public string type { get; set; }
		public string description { get; set; }

		[JsonProperty("x-cc-api-group")]
		public string xccapigroup { get; set; }
	}



}
