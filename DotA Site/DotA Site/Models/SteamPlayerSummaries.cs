using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace DotA_Site.Models
{
	public class SteamPlayerSummaries
	{
		public SteamPlayerSummariesResponse response = new SteamPlayerSummariesResponse();

		private void populateResponse(string jsonResult)
		{
			SteamPlayerSummaries temp = JsonConvert.DeserializeObject<SteamPlayerSummaries>(jsonResult);
			this.response = temp.response;
		}

		public string getPlayerName(Int64 steamId32)
		{
			Int64 steamId64 = 0;
			DotaAPI caller = new DotaAPI();
			string jsonResult = string.Empty;

			if (steamId32 == 4294967295)
				return "Anonymous";

			steamId64 = steamId32 + 76561197960265728;
			jsonResult = caller.callSteamAPI("steamids=" + steamId64.ToString());

			this.populateResponse(jsonResult);

			return this.response.players[0].personaname;
		}
	}
}